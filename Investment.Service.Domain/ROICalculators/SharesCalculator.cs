using Investment.Service.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.Service.Domain.ROICalculators
{
    public class SharesCalculator : IROICalculator
    {
        private const decimal SharePercentage = 70m;
        private const decimal RateWhenPercentageGreaterThan70 = 0.06m;
        private const decimal FeeWhenPercentageGreaterThan70 = 0.025m;
        private const decimal RateWhenPercentageLessThan70 = 0.043m;
        private const decimal FeeWhenPercentageLessThan70 = 0.025m;

        public (decimal InvestmentReturn, decimal Fee) Calculate(decimal amount, decimal percentage)
        {
            decimal investementReturn;
            decimal fee;

            if (percentage > SharePercentage)
            {
                investementReturn = amount * RateWhenPercentageGreaterThan70;
                fee = investementReturn * FeeWhenPercentageGreaterThan70;
            }
            else
            {
                investementReturn = amount * RateWhenPercentageLessThan70;
                fee = investementReturn * FeeWhenPercentageLessThan70;
            }

            return (investementReturn, fee);
        }
    }
}
