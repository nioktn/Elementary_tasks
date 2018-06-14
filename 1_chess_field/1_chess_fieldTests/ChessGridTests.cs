using _1_chess_field;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _1_chess_fieldTests
{
    [TestClass]
    public class ChessGridTests
    {
        [TestMethod]
        public void GetGridTest()
        {
            int height = 3, width = 3;
            String expectedString = "* * *\n * * *\n* * *";
            ChessGrid cg = new ChessGrid(height, width, '*');
            String actualString = cg.GetGrid();
            Assert.AreEqual(expectedString, actualString);
        }
    }
}
