using Microsoft.VisualStudio.TestTools.UnitTesting;
using Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments.Tests
{
    [TestClass()]
    public class ValidatorTests
    {
        [TestMethod()]
        public void ClearStringTest_ws_nows()
        {
            String str = "\t \t \t Hell o\t    Wo r\tl  d!1\t   ";
            String expectedResult = "HelloWorld!1";
            String actualResult = Validator.ClearString(str);
            StringAssert.Equals(expectedResult, actualResult);
        }

        [TestMethod()]
        public void IsPositiveTest_positiveInt_false()
        {
            int num = 100;
            bool expectedResult = true;
            bool actualResult = Validator.IsPositive(num);
            Assert.AreEqual(expectedResult, actualResult);
        }
                
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void IsPositiveTest_negativeInt_Ex()
        {
            int num = -54;
            Validator.IsPositive(num);
        }

        [TestMethod()]
        public void ReadFractionTest_positiveDouble_true()
        {
            double num = 567.42;
            bool expectedResult = true;
            bool actualResult = Validator.IsPositive(num);
            Assert.AreEqual(expectedResult, actualResult);
        }
                
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void IsPositiveTest_negativeDouble_Ex()
        {
            double num = -3.14;
            Validator.IsPositive(num);
        }
    }
}