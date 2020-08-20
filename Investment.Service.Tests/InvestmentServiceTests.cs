using Investment.Service.Domain;
using Investment.Service.Domain.Services;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Investment.Service.Tests
{
    public class InvestmentServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetInvestmentOptionShouldReturnResult()
        {
            // Arrange
            var sut = new InvestmentService();

            // Act
            var options = sut.GetInvestmentOptions();

            // Assert
            Assert.IsTrue(options.Count() > 0);
        }

        [Test]
        public void CalculateResultShouldReturnCorrectAmount()
        {
            // Arrange
            var sut = new InvestmentService();
            var investmentDetails = new List<InvestmentDetail> 
            {
                new InvestmentDetail
                {
                    InvestmentOptionId = 1,
                    Amount = 1000m,
                    Percentage = 100m
                }
            };

            // Act
            var result = sut.CalculateResult(investmentDetails);

            // Assert
            Assert.AreEqual(result.InvestmentReturn, 100m);
            Assert.AreEqual(result.Fees, 0m);
        }
    }
}