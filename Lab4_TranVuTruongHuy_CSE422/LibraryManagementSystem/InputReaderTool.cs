using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class InputReaderTool
    {
        public int GetInputInConsole(string requiredText) {
            Console.WriteLine($"{requiredText}: ");
            return int.Parse(Console.ReadLine());
        }
        public string GetInputInConsole(string requiredText, string check)
        {
            Console.WriteLine($"{requiredText}: ");
            return Console.ReadLine();
        }

    }
}
