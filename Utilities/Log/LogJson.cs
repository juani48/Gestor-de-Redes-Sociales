using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CshaprSocialNetWorkManager.Utilities.Log
{
    public class LogJson : ILog<LogObject>, ILog<string>
    {
        public void SaveLog(LogObject action)
        {
            string logPath = Directory.GetCurrentDirectory() + "\\Log.json";
            string currentContent = string.Empty;

            List<LogObject> logObjs = new List<LogObject>();

            if (File.Exists(logPath))
            {
                var sr = new StreamReader(logPath);
                currentContent = sr.ReadToEnd();
                logObjs = JsonConvert.DeserializeObject<List<LogObject>>(currentContent);
                sr.Close();
            }
            var sw = new StreamWriter(logPath);

            logObjs.Add(action);

            var jsonResult = JsonConvert.SerializeObject(logObjs);

            sw.WriteLine(jsonResult);
            sw.Close();
        }

        public void SaveLog(string action)
        {
            string logPath = Directory.GetCurrentDirectory() + "\\Log.json";
            string currentContent = string.Empty;

            List<LogObject> logObjs = new List<LogObject>();

            if (File.Exists(logPath))
            {
                var sr = new StreamReader(logPath);
                currentContent = sr.ReadToEnd();
                logObjs = JsonConvert.DeserializeObject<List<LogObject>>(currentContent);
                sr.Close();
            }
            var sw = new StreamWriter(logPath);

            logObjs.Add(new LogObject() { Action = action, LogDate = DateTime.Now });

            var jsonResult = JsonConvert.SerializeObject(logObjs);

            sw.WriteLine(jsonResult);
            sw.Close();
        }
    }
}
