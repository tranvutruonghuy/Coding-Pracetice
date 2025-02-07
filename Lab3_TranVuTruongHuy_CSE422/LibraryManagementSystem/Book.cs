using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book : IPrintable
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        private int _year;
        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Year cannot be less than 0.");
                }
                _year = value;
            }
        }
        private int _copiesAvailable;
        public int CopiesAvailable
        {
            get { return _copiesAvailable; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("CopiesAvailable cannot be less than 0.");
                }
                _copiesAvailable = value;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Copies Available: {CopiesAvailable}");
        }

        public void PrintDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Copies Available: {CopiesAvailable}");
        }
    }
}
