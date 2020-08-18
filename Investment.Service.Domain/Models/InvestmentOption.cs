using Investment.Service.Domain.Interfaces;

namespace Investment.Service.Domain.Models
{
    public class InvestmentOption
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public IROICalculator ROICalculator { get; set; }

        public InvestmentOption(string name, int id, IROICalculator calculator)
        {
            Name = name;
            Id = id;
            ROICalculator = calculator;
        }
    }
}
