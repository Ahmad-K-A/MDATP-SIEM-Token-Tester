using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDATP_SIEM_Checker
{
    public static class Logger
    {
        public static void WriteLog(string logmessage)
        {
            var Date = DateTime.Now.ToString("yyyy - MM - dd HH: mm:sss");
            var logline = Date + " :" + Environment.NewLine + logmessage + Environment.NewLine + "------------------------------" + Environment.NewLine + Environment.NewLine;
            System.IO.File.AppendAllText("SIEMlog.txt",logline);
        }
    }
}
