using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace qBT.Core
{
    public interface ITorrentApi
    {
        Task<bool> PauseAllTorrents();
        Task<bool> ResumeAllTorrents();

        Task<bool> PauseTorrents(IEnumerable<string> hashes);

        Task<bool> ResumeTorrents(IEnumerable<string> hashes);
    }
}
