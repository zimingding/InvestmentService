using Investment.Service.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.Service.Domain.ROICalculators
{
    public class ExchangeTradedFundsCalculator : IROICalculator
    {
        public (decimal InvestmentReturn, decimal Fee) Calculate(decimal amount, decimal percentage)
        {
            throw new NotImplementedException();
        }
    }
}
