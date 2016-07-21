﻿using PT.Fibonacci.Application.Base.Services;
using PT.Fibonacci.Infrastructure.Base.Logging;
using System.Threading;
using PT.Fibonacci.Domain;

namespace PT.Fibonacci.Application.Services
{
    public class FibonacciIterativeService : IFibonacciService
    {
        private static readonly ILogger Logger = LoggerFactory.CreateLog();

        public FibonacciResponse CalculateFibonacci(FibonacciRequest request)
        {
            Logger.LogInfo($"Starting calculation for {request.Number}");

            Thread.Sleep(500);

            var result = new FibonacciNumber(
                CalculateNthFibonacciNumber(request.Number.Index + 1),
                request.Number.Index + 1);

            return new FibonacciResponse(result);
        }

        private static decimal CalculateNthFibonacciNumber(int index)
        {
            var fibonacciNumbers = new decimal[index + 1];

            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;

            for (var i = 2; i <= index; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 2] + fibonacciNumbers[i - 1];
            }

            return fibonacciNumbers[index];
        }
    }
}
