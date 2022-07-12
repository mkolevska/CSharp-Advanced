using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class11.Homework.TreeCommand.HelperService
{
    public static class Logger
    {
        public static void Log(string error)
        {
            var msg = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} - {error}";
            File.AppendAllLines("log.txt", new List<string> { msg });
        }
    }
}
