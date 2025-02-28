using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Newspaper : IDocument
    {
        public string Id { get; }
        public string Title { get; }

        public Newspaper(string id, string title)
        {
            Id = id;
            Title = title;
        }

        public double CalculateBaseFee()
        {
            return 0.5;
        }
    }
}
