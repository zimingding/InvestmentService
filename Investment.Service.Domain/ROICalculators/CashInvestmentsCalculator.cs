using Investment.Service.Domain.Interfaces;

namespace Investment.Service.Domain.ROICalculators
{
    public class CashInvestmentsCalculator : IROICalculator
    {
        private const decimal CashPercentage = 50m;
        private const decimal RateWhenPercentageGreaterThan50 = 0.1m;
        private const decimal FeeWhenPercentageGreaterThan50 = 0;
        private const decimal RateWhenPercentageLessThan50 = 0.085m;
        private const decimal FeeWhenPercentageLessThan50 = 0.005m;

        public (decimal InvestmentReturn, decimal Fee) Calculate(decimal amount, decimal percentage)
        {
            decimal investementReturn;
            decimal fee;

            if (percentage > CashPercentage)
            {
                investementReturn = amount * RateWhenPercentageGreaterThan50;
                fee = investementReturn * FeeWhenPercentageGreaterThan50;
            }
            else
            {
                investementReturn = amount * RateWhenPercentageLessThan50;
                fee = investementReturn * FeeWhenPercentageLessThan50;
            }

            return (investementReturn, fee);
        }
    }
}
