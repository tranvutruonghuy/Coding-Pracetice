using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class StandardFeeStrategy : IFeeCalculationStrategy
    {
        public double CalculateFee(IDocument document, int days)
        {
            return document.CalculateBaseFee() * days;
        }
    }
}
