using Microsoft.VisualStudio.TestTools.UnitTesting;
using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Application.Services;
using PT.Fibonacci.Domain;
using PT.Fibonacci.Infrastructure.Base.Logging;
using PT.Fibonacci.Infrastructure.Logging;

namespace PT.Fibonacci.Application.Test.Services
{
    [TestClass]
    public class FibonacciIterativeServiceTest
    {
        [TestInitialize]
        public void SetUp()
        {
            LoggerFactory.SetCurrent(new DoNothingLogFactory());
        }

        [TestMethod]
        public void CalculateNthNumberTests()
        {
            var service = new FibonacciIterativeService();

            Assert.AreEqual(1, service.CalculateFibonacci(new FibonacciRequest(new FibonacciNumber(0, 0), string.Empty)).Number.Value);
            Assert.AreEqual(1, service.CalculateFibonacci(new FibonacciRequest(new FibonacciNumber(0, 1), string.Empty)).Number.Value);
            Assert.AreEqual(2, service.CalculateFibonacci(new FibonacciRequest(new FibonacciNumber(0, 2), string.Empty)).Number.Value);
            Assert.AreEqual(3, service.CalculateFibonacci(new FibonacciRequest(new FibonacciNumber(0, 3), string.Empty)).Number.Value);
            Assert.AreEqual(5, service.CalculateFibonacci(new FibonacciRequest(new FibonacciNumber(0, 4), string.Empty)).Number.Value);
            Assert.AreEqual(8, service.CalculateFibonacci(new FibonacciRequest(new FibonacciNumber(0, 5), string.Empty)).Number.Value);
            Assert.AreEqual(13, service.CalculateFibonacci(new FibonacciRequest(new FibonacciNumber(0, 6), string.Empty)).Number.Value);
            Assert.AreEqual(21, service.CalculateFibonacci(new FibonacciRequest(new FibonacciNumber(0, 7), string.Empty)).Number.Value);
            Assert.AreEqual(34, service.CalculateFibonacci(new FibonacciRequest(new FibonacciNumber(0, 8), string.Empty)).Number.Value);
            Assert.AreEqual(55, service.CalculateFibonacci(new FibonacciRequest(new FibonacciNumber(0, 9), string.Empty)).Number.Value);
        }
    }
}
