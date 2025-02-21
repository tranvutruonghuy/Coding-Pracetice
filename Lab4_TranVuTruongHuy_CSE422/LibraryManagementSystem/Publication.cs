using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class Publication : IPrintable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }

        protected Publication(int id, string title, string author, string category, int quantity)
        {
            Id = id;
            Title = title;
            Author = author;
            Category = category;
            Quantity = quantity;
        }
        public void UpdateQuantityAfterReturned()
        {
            this.Quantity++;
        }
        public void UpdateQuantityAfterLended()
        {
            this.Quantity--;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"In stock: {Quantity}");
        }
    }
}
