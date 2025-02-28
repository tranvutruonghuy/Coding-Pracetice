using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class OverdueFeeStrategy : IFeeCalculationStrategy
    {
        public double CalculateFee(IDocument document, int days)
        {
            double baseFee = document.CalculateBaseFee();
            return days <= 14 ? baseFee * days : baseFee * days * 1.5;
        }
    }
}
