using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        public string LibraryName { get; set; }
        public List<Book> Books { get; set; }   
        public List<Member> Members { get; set; }
        public Library()
        {
            LibraryName = "Default Library";
            Books = new List<Book>();
            Members = new List<Member>();
        }
        public Library(string libraryName, List<Book> books)
        {
            LibraryName = libraryName;
            Books = books;
            Members = new List<Member>();
        }
        public Library(Library existingLibrary)
        {
            LibraryName = existingLibrary.LibraryName;
            Books = new List<Book>(existingLibrary.Books);
            Members = new List<Member>(existingLibrary.Members);
        }

        public void BorrowBook(Book book, Member member)
        {
            if (book.CopiesAvailable > 0)
            {
                book.CopiesAvailable--;
                Console.WriteLine($"{member.Name} borrowed {book.Title}");

                // Trigger the event
                OnBookBorrowed?.Invoke(book, member);
            }
            else
            {
                Console.WriteLine($"Book not available: {book.Title}");
            }
        }
        public event Action<Book, Member> OnBookBorrowed;

        public void DisplayLibraryInfo()
        {
            Console.WriteLine($"Library Name: {LibraryName}");
            Console.WriteLine($"Number of Books: {Books.Count}");
            Console.WriteLine($"Number of Members: {Members.Count}");
        }
    }
}
