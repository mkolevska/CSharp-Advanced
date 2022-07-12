using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class11.Homework.TreeCommand.HelperService
{
    public static class Helper
    {
        public static void WriteFolders(string folder)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(folder);
            Console.ResetColor();
        }

        public static void WriteFiles(string file)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(file);
            Console.ResetColor();
        }
    }
}
