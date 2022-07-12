using SEDC.Oop.Class11.Homework.TreeCommand.HelperService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class11.Homework.TreeCommand.Entities
{
    public class FileWriter
    {
        public static void WriteFile(string folderName, List<string> file)
        {
            try
            {
                if (File.Exists(folderName))
                {
                    throw new Exception("The tree is not written in a file, because a file with that name already exists.");
                }
                else
                {
                    File.AppendAllLines(folderName, file);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
                Logger.Log(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
