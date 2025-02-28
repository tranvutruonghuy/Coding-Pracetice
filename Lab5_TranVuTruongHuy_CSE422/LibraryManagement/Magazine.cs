using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Magazine : IDocument
    {
        public string Id { get; }
        public string Title { get; }

        public Magazine(string id, string title)
        {
            Id = id;
            Title = title;
        }

        public double CalculateBaseFee()
        {
            return 1;
        }
    }
}
