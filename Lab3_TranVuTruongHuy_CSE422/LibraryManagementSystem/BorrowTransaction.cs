using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class BorrowTransaction : Transaction
    {
        public Book BookBorrowed { get; set; }
        public override void Execute()
        {
            if (BookBorrowed.CopiesAvailable == 0)
            {
                Console.WriteLine($"{BookBorrowed.Title} is not avalable!");
            }
            else
            {
                BookBorrowed.CopiesAvailable--;
                Console.WriteLine($"{BookBorrowed.Title} is borrowed successfully!");
            }
            
        }
    }
}
