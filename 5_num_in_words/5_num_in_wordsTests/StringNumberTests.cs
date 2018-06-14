using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5_num_in_words;

namespace _5_num_in_wordsTests
{
    [TestClass]
    public class StringNumberTests
    {
        [TestMethod]
        public void CreateStringTest_9223372036854775807_Str()
        {
            long num = 9223372036854775807;
            String expectedResult = "Девять квинтиллионов двести двадцать три квадриллионa триста семьдесят два триллионa " +
                "тридцать шесть миллиардов восемьсот пятьдесят четире миллионa семьсот семьдесят пять тысяч восемьсот семь";
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
