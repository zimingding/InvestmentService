using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.Service.Domain.Interfaces
{
    public interface IROICalculator
    {
        (decimal InvestmentReturn, decimal Fee) Calculate(decimal amount, decimal percentage);
    }
}
