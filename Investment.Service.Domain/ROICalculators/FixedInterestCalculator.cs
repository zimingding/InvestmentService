namespace Investment.Service.Domain.ROICalculators
{
    public class FixedInterestCalculator : SimpleCalculator
    {
        public override decimal ReturnRate => 0.1m;
        public override decimal FeeRate => 0.01m;
    }
}
