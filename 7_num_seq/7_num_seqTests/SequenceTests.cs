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
            double minSqr = 83;
            String expectedResult = "10, 11, 12, 13, 14, 15, 16, 17, 18, 19";
            String actualResult = Sequence.GetSeqString(N, minSqr);
            StringAssert.Equals(expectedResult, actualResult);
        }
    }
}
