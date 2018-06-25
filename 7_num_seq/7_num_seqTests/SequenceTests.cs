using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _7_num_seq;

namespace _7_num_seqTests
{
    [TestClass]
    public class SequenceTests
    {
        [TestMethod]
        public void GetSeqStringTest_10_83_seqStr()
        {
            int N = 10;
            double minSqr = 288;
            String expectedResult = "17, 18, 19, 20, 21, 22, 23, 24, 25, 26";
            String actualResult = Sequence.GetSeqString(N, minSqr);
            StringAssert.Equals(expectedResult, actualResult);
        }
    }
}
