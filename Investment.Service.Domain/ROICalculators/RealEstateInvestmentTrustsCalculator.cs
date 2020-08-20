namespace Investment.Service.Domain.ROICalculators
{
    public class RealEstateInvestmentTrustsCalculator : SimpleCalculator
    {
        public override decimal ReturnRate  => 0.04m;
        public override decimal FeeRate => 0.02m;
    }
}
