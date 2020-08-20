namespace Investment.Service.Domain.ROICalculators
{
    public class ManagedFundsCalculator : SimpleCalculator
    {
        public override decimal ReturnRate => 0.12m;
        public override decimal FeeRate => 0.003m;
    }
}
