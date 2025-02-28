using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public interface IDocument
    {
        string Id { get; }
        string Title { get; }
        double CalculateBaseFee();
    }
}
