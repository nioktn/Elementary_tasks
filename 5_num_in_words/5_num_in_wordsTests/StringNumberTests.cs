using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5_num_in_words;

namespace _5_num_in_wordsTests
{
    [TestClass]
    public class StringNumberTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "StringNumbers.xml", "StringNumberRow", DataAccessMethod.Sequential)]

        [TestMethod]
        public void CreateStringTest()
        {
            long num = Convert.ToInt64(TestContext.DataRow["Number"]);
            String expectedResult = TestContext.DataRow["String"].ToString();
            String actualResult = StringNumber.CreateString(num);
            StringAssert.Equals(expectedResult, actualResult);
        }

        [TestMethod()]
        public void UppercaseFirstTest_hello_Hello()
        {
            String str = "hello";
            String expectedResult = "Hello";
            String actualResult = StringNumber.UppercaseFirst(str);
            StringAssert.Equals(expectedResult, actualResult);
        }
    }
}
