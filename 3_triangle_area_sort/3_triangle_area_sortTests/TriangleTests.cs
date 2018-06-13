using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_triangle_area_sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_triangle_area_sort.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void CalculateAreaTest_567_14697()
        {
            double a = 5;
            double b = 6;
            double c = 7;
            double delta = 0.0001;
            double expectedResult = 14.697;

            double actualResult = Triangle.CalculateTriangleArea(a, b, c);

            Assert.AreEqual(expectedResult, actualResult, delta);
        }
        [TestMethod]
        public void isTriangleExistsTest_115_false()
        {
            double a = 1;
            double b = 1;
            double c = 5;
            bool expectedResult = false;

            bool actualResult = Triangle.isTriangleExists(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CompareToTest_334_552_false()
        {
            Triangle first = new Triangle("first", 3, 3, 4);
            Triangle second = new Triangle("second", 5, 5, 2);
            bool expectedResult = false;

            bool actualResult = first.CompareTo(second) > 0;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}