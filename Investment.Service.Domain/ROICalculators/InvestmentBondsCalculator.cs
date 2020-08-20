namespace Investment.Service.Domain.ROICalculators
{
    public class InvestmentBondsCalculator : SimpleCalculator
    {
        public override decimal ReturnRate => 0.08m;
        public override decimal FeeRate => 0.009m;
    }
}
