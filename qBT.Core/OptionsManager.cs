using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace qBT.Core
{
    public class OptionsManager
    {
        public static Options GetOptions(string pathFileOptions = "options.json")
        {
            Options options;
            if (File.Exists(pathFileOptions))
            {
                string str = File.ReadAllText(pathFileOptions);
                options = JsonConvert.DeserializeObject<Options>(str);
            }
            else
            {
                options = Options.GetDefault();
            }

            return options;
        }

        public static void SaveOptions(Options options, string pathFileOptions = "options.json")
        {
            if (File.Exists(pathFileOptions))
            {
                string str = JsonConvert.SerializeObject(options);
                File.WriteAllText(pathFileOptions, str);
            }

        }
    }
}
