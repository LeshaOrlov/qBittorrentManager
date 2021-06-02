using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using System.Security;
using System.Net;

namespace qBT.Core{
    public class qBitttorrentApi: ITorrentApi
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _httpClientHandler;
        
        private Options _option;
        private readonly IMessager _messager = new EmptyMessager();

        public qBitttorrentApi(Options option)
        {
            _option = option;
            _httpClientHandler = new HttpClientHandler();
            _httpClient = new HttpClient(_httpClientHandler) { BaseAddress = new Uri(option.URL) };
        }

        private bool IsAuthenticated()
        {
            return _httpClientHandler.CookieContainer.GetCookies(_httpClient.BaseAddress)["SID"] != null;
        }

        private async Task CheckAuthentification()
        {
            if (!IsAuthenticated())
            {
                if (!await Login())
                {
                    throw new SecurityException();
                }
            }
        }

        private async Task<bool> Login()
        {
            HttpContent bodyContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", _option.UserName),
                new KeyValuePair<string, string>("password", _option.Password)
            });

            var uri = new Uri("api/v2/auth/login", UriKind.Relative);
            await _httpClient.PostAsync(uri, bodyContent);

            return IsAuthenticated();
        }

        public async Task<IList<Torrent>> GetTorrents(Filter filter = Filter.All, string category = null)
        {
            await CheckAuthentification();

            var keyValuePairs = new KeyValuePair<string, string>[2];
            keyValuePairs.SetValue(new KeyValuePair<string, string>("filter", filter.ToString().ToLower()), 0);

            if (category != null)
            {
                keyValuePairs.SetValue(new KeyValuePair<string, string>("category", category), 1);
            }

            HttpContent content = new FormUrlEncodedContent(keyValuePairs);

            var uri = new Uri("/query/torrents?" + await content.ReadAsStringAsync(), UriKind.Relative);
            var response = await _httpClient.GetAsync(uri);
            var jsonStr = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IList<Torrent>>(jsonStr);
        }

        public async Task<bool> PauseAllTorrents(){
            await CheckAuthentification();
            List<Torrent> actionsTorrents = await GetTorrentList("actions");
            if (actionsTorrents.Count > 0)
                return await PauseTorrents(actionsTorrents.Select(x => x.Hash));
            return true;
        }

        public async Task<bool> ResumeAllTorrents(){
            await CheckAuthentification();
            List<Torrent> stoppedTorrents = await GetTorrentList();
            if (stoppedTorrents.Count > 0)
                return await ResumeTorrents(stoppedTorrents.Select(x => x.Hash));
            return true;
        }

        public async Task<bool> PauseTorrents(IEnumerable<string> hashes){
            await CheckAuthentification();
            string request = @"/api/v2/torrents/pause?hashes=" +string.Join("|", hashes);
            var responce = await _httpClient.GetAsync(request);
            return responce.IsSuccessStatusCode;
        }

        public async Task<bool> ResumeTorrents(IEnumerable<string> hashes)
        {
            await CheckAuthentification();
            string request = @"/api/v2/torrents/resume?hashes=" + string.Join("|", hashes);
            var responce = await _httpClient.GetAsync(request);
            return responce.IsSuccessStatusCode;
        }

            public async Task<List<Torrent>> GetTorrentList(string filter = ""/*, string category = "", string sort = "", bool? reverse = null, int? limit = null, int? offset = null, string hashes = ""*/){

            string request = @"/api/v2/torrents/info";
            if (!String.IsNullOrWhiteSpace(filter)){
                request += "?filter=" + filter;
            }
            string responce = string.Empty;
            try
            {
                responce = await _httpClient.GetStringAsync(request);
            }
            catch(HttpRequestException ex)
            {
                _messager.Message(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                _messager.Message(ex.Message);
            }

            var result = JsonConvert.DeserializeObject<List<Torrent>>(responce) ?? new List<Torrent>();
            return result;
            //result.ForEach(x => Console.WriteLine("Name: {0}, Hash:{1}",x.Name, x.Hash));
        }

    }
    
}