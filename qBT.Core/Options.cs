using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace qBT.Core
{
    public class Options
    {
        public string IPAddress { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int SleepTime { get; set; }

        //public string PathToProgram { get; set; }
        public string[] ListProcess { get; set; }

        public string URL { 
            get { return IPAddress + ":" + Port.ToString(); } 
        }

        public static Options GetDefault()
        {
            return new Options()
            {
                IPAddress = "http://localhost",
                Port = 8080,
                SleepTime = 5000,
            };
        }

        public string GetUrl()
        {
            return IPAddress + ":" + Port.ToString();
        }
    }
}
