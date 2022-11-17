using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader
{
    internal class ReadInKeyboard : IReader
    {
        private List<string> _readInKeyboard;
        public ReadInKeyboard()
        {
            _readInKeyboard = new List<string>();
        }

        public void Read()
        {
            Console.WriteLine("Enter the information to be read");
            string read = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Information read");
            Console.WriteLine($"The information you recorded {read}");
        }
        public void AllInfo()
        {
            foreach(string info in _readInKeyboard)
            {
                Console.WriteLine(info);
            }
        }
    }
}
