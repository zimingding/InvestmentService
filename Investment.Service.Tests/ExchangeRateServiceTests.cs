using Investment.Service.Domain.Interfaces;
using Investment.Service.Domain.ROICalculators;
using Investment.Service.Domain.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.Service.Tests
{
    public class ExchangeRateServiceTests
    {
        [Test]
        public void ExchangeShouldCalculateCorrectly()
        {
            // Arrange
            var repository = new Mock<IExchangeRateRepository>();
            repository.Setup(x => x.GetExchangeRate(It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync(0.8m);
            var sut = new ExchangeRateService(repository.Object);

            // Act
            var result = sut.Exchange("AUD", "USD", 100);

            // Assert
            Assert.AreEqual(result, 80m);
        }
    }
}
