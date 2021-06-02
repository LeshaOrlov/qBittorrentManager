using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace qBT.Core
{
    class ProcessValidator
    {
        public bool Validate(Options option)
        {
            IEnumerable<string> listProcess = Process.GetProcesses().Select(x => x.ProcessName);
            bool valid = option.ListProcess.Intersect(listProcess).Count() > 0;
            return valid;
        }
    }
}
