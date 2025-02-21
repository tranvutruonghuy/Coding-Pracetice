using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Admin : IPrintable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Admin(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddNewBook(LibraryManager library, InputReaderTool inputReaderTool)
        {
            Console.WriteLine("Enter the information below to add book: ");
  
            int id = inputReaderTool.GetInputInConsole("Id");

            string title = inputReaderTool.GetInputInConsole("Title", "check");

            string author = inputReaderTool.GetInputInConsole("Author", "check"); ;

            string category = inputReaderTool.GetInputInConsole("Category", "check"); ;

            int quantity = inputReaderTool.GetInputInConsole("Quantity");
            Publication newBook = new Book(id, title, author, category, quantity);
            library.PublicationManagement.AddBookToList(newBook);
        }

        public void PrintDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine();
        }
    }
}