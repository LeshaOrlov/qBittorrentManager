using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace qBT.Core
{
    public class TorrentServerManager
    {
        private ITorrentApi _torrentControl;
        private List<string> _processList;
        private IMessager _messager;
        private bool _canseled = false;
        private Task task;
        private Options _option;

        public TorrentServerManager()
        {
            _option = OptionsManager.GetOptions();
            _torrentControl = new qBitttorrentApi(_option);
        }

        public TorrentServerManager(ITorrentApi qBitControl, Options option = null, IMessager messager = null)
        {
            _option = OptionsManager.GetOptions();
            _torrentControl = qBitControl;
            _messager = messager ?? new EmptyMessager();
        }

        public void SetProcessList(List<string> processList)
        {
            _processList = processList;
        }

        public void SetSleepTime(int sleepTime)
        {
            _option.SleepTime = sleepTime;
        }

        public void Stop()
        {
            _canseled = true;
            task.Wait();
            task.Dispose();
        }

        public void Start()
        {
            task = new Task(() => Run());
            task.Start();
        }

        public bool IsRunning()
        {
            return task.Status == TaskStatus.Running;
        }

        private async void Run()
        {
            if (_messager != null)
                _messager.Message("Start loop");
            _canseled = false;
            IEnumerable<string> listProcess;
            while (!_canseled)
            {
                listProcess = Process.GetProcesses().Select(x => x.ProcessName);
                try
                {
                    if (_processList.Intersect(listProcess).Count() > 0)
                    {
                        await _torrentControl.PauseAllTorrents();
                        if (_messager != null)
                            _messager.Message("PauseAllTorrents");
                    }
                    else
                    {
                        await _torrentControl.ResumeAllTorrents();
                        if (_messager != null)
                            _messager.Message("ResumeAllTorrents");
                    }
                    Thread.Sleep(_option.SleepTime);
                }
                catch (Exception ex)
                {
                    _messager.Message(ex.Message);
                }
            }
            _messager.Message("Stop loop");
        }

    }
}
