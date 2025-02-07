using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Member : IPrintable, IMemberActions
    {
        public string MemberID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Member ID: " +  MemberID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
        }

        public void PrintDetails()
        {
            Console.WriteLine("Member ID: " + MemberID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
        }

        public void BorrowBook(Book book)
        {
            if (book.CopiesAvailable == 0)
            {
                Console.WriteLine($"{book.Title} is not avalable!");
            }
            else
            {
                book.CopiesAvailable--;
                Console.WriteLine($"{Name} borrowed {book.Title} successfully!");
            }
        }

        public void ReturnBook(Book book)
        {
            book.CopiesAvailable++;
            Console.WriteLine($"{Name} returned {book.Title}");
        }
    }
}
