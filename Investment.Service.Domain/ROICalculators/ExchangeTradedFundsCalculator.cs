namespace Investment.Service.Domain.ROICalculators
{
    public class ExchangeTradedFundsCalculator : SimpleCalculator
    {
        // Requirement missing, set return rate to fixed 12.8%
        public override decimal ReturnRate => 0.128m;
        public override decimal FeeRate => 0.02m;
    }
}
