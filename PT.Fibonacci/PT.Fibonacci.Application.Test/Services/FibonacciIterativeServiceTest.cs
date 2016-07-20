using Microsoft.VisualStudio.TestTools.UnitTesting;
using PT.Fibonacci.Application.Services;
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

            Assert.AreEqual(1, FibonacciIterativeService.CalculateNthFibonacciNumber(1));
            Assert.AreEqual(1, FibonacciIterativeService.CalculateNthFibonacciNumber(2));
            Assert.AreEqual(2, FibonacciIterativeService.CalculateNthFibonacciNumber(3));
            Assert.AreEqual(3, FibonacciIterativeService.CalculateNthFibonacciNumber(4));
            Assert.AreEqual(5, FibonacciIterativeService.CalculateNthFibonacciNumber(5));
            Assert.AreEqual(8, FibonacciIterativeService.CalculateNthFibonacciNumber(6));
            Assert.AreEqual(13, FibonacciIterativeService.CalculateNthFibonacciNumber(7));
            Assert.AreEqual(21, FibonacciIterativeService.CalculateNthFibonacciNumber(8));
            Assert.AreEqual(34, FibonacciIterativeService.CalculateNthFibonacciNumber(9));
            Assert.AreEqual(55, FibonacciIterativeService.CalculateNthFibonacciNumber(10));
        }
    }
}
