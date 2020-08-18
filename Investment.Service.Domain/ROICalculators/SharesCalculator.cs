using Investment.Service.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.Service.Domain.ROICalculators
{
    public class SharesCalculator : IROICalculator
    {
        public (decimal InvestmentReturn, decimal Fee) Calculate(decimal amount, decimal percentage)
        {
            throw new NotImplementedException();
        }
    }
}
