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
            //arrange
            int height = 3;
            int width = 3;
            String expectedResult = "* * *\n * * *\n* * *";

            //act
            ChessGrid cg = new ChessGrid(height, width, '*');
            String actualResult = cg.GetGrid();

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
