using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book : IDocument
    {
        public string Id { get; }
        public string Title { get; }

        public Book(string id, string title)
        {
            Id = id;
            Title = title;
        }

        public double CalculateBaseFee()
        {
            return 2.0;
        }
    }
}
