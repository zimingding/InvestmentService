namespace Investment.Service.Domain.ROICalculators
{
    public class AnnuitiesCalculator : SimpleCalculator
    {
        public override decimal ReturnRate => 0.04m;
        public override decimal FeeRate => 0.014m;
    }
}
