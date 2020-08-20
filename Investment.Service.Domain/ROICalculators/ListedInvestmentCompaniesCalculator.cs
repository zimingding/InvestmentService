namespace Investment.Service.Domain.ROICalculators
{
    public class ListedInvestmentCompaniesCalculator : SimpleCalculator
    {
        public override decimal ReturnRate => 0.06m;
        public override decimal FeeRate => 0.013m;
    }
}
