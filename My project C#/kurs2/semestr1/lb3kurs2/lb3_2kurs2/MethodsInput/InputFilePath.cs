using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3_2kurs2.MethodsInput
{
    public class InputFilePath
    {
        public static string InputfilePath() {
            string filePath;
            while (true)
            {
               
                filePath = Console.ReadLine();
                if (filePath != null && File.Exists(filePath))
                {
                    Console.WriteLine("file found");
                    break;
                }
                Console.WriteLine("File not found; try again.");
            }
            return filePath;
        }
    }
}
