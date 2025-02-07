using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class ReturnTransaction : Transaction
    {
        public Book BookReturned { get; set; }

        public override void Execute()
        {
            BookReturned.CopiesAvailable++;
            Console.WriteLine($"{BookReturned.Title} is returned successfully!");
        }
    }
}
