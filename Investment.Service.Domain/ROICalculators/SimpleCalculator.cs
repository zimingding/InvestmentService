using Investment.Service.Domain.Interfaces;

namespace Investment.Service.Domain.ROICalculators
{
    public class SimpleCalculator : IROICalculator
    {
        public virtual decimal ReturnRate { get; }
        public virtual decimal FeeRate { get; }

        public (decimal InvestmentReturn, decimal Fee) Calculate(decimal amount, decimal percentage)
        {
            var investmentReturn = amount * ReturnRate;
            var fee = investmentReturn * FeeRate;

            return (investmentReturn, fee);
        }
    }
}
