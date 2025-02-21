using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book : Publication
    {
        public Book(int id, string title, string author, string category, int quantity) : base(id, title, author, category, quantity)
        {
        }
    }
}
