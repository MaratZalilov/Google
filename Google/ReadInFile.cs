using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Reader
{
    internal class ReadInFile : IReader
    {
        public ReadInFile()
        {

        }
        public void Read()
        {
            Console.WriteLine("Specify the path");
            string path = Console.ReadLine();
            FileInfo fileInfo = new FileInfo($@"{path}.txt");
            if (fileInfo.Exists)
            {
                Console.WriteLine("123");
                Console.WriteLine();
                string Read1 = Console.ReadLine();
                using (StreamWriter streamWriter = new StreamWriter(fileInfo.FullName, true))
                {                   
                    streamWriter.Write(Read1);
                    Console.WriteLine($" Read'n information {Read1}");
                }
            }

        }
    }
}
