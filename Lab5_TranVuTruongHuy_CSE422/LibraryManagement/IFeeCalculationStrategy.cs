﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public interface IFeeCalculationStrategy
    {
        double CalculateFee(IDocument document, int days);
    }
}
