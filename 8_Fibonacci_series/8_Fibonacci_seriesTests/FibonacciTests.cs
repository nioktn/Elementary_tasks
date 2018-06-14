using Microsoft.VisualStudio.TestTools.UnitTesting;
using _8_Fibonacci_series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Fibonacci_seriesTests
{
    [TestClass()]
    public class FibonacciTests
    {
        [TestMethod()]
        public void CalcFbncTest_15_1500_list()
        {
            long min = 15;
            long max = 1500;
            List<long> expectedResult = new List<long> { 21, 34, 55, 89, 144, 233, 377, 610, 987 };
            List<long> actualResult = Fibonacci.CalcFbnc(min, max);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void CalcFbncTest_10()
        {
            long numLength = 10;
            List<long> expectedResult = new List<long> { 1134903170, 1836311903, 2971215073, 4807526976, 7778742049 };
            List<long> actualResult = Fibonacci.CalcFbnc(numLength);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}