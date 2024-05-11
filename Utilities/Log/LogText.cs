using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CshaprSocialNetWorkManager.Utilities.Log
{
    public class LogText : ILog<string>, ILogText
    {
        public string GetLogText()
        {
            string logPath = Directory.GetCurrentDirectory() + "\\Log.txt";
            string currentContent = string.Empty;

            if (File.Exists(logPath))
            {
                var sr = new StreamReader(logPath);
                currentContent = sr.ReadToEnd();
                sr.Close();
            }
            return currentContent;
        }

        public void SaveLog(string action)
        {
            string logPath = Directory.GetCurrentDirectory() + "\\Log.txt";
            string currentContent = string.Empty;

            if (File.Exists(logPath))
            {
                var sr = new StreamReader(logPath);
                currentContent = sr.ReadToEnd();
                sr.Close();
            }
            var sw = new StreamWriter(logPath);

            sw.WriteLine($"{DateTime.Now} - {action}");
            sw.WriteLine(currentContent);
            sw.Close();
        }
    }
}
