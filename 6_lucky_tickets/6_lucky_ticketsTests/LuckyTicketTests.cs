using Microsoft.VisualStudio.TestTools.UnitTesting;
using _6_lucky_tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _6_lucky_ticketsTests
{
    [TestClass()]
    public class LuckyTicketTests
    {
        [TestMethod()]
        public void Check_ticket_numTest_00233232_true()
        {
            String ticketNum = "00233232";
            Assert.IsTrue(LuckyTicket.CheckTicketNum(ticketNum));
        }

        [TestMethod()]
        public void ComplexTest_032560_true()
        {
            int[] ticketNumArray = { 0, 3, 2, 5, 6, 0 };
            Assert.IsTrue(LuckyTicket.Complex(ticketNumArray));
        }

        [TestMethod()]
        public void SimpleTest_10420304_true()
        {
            int[] ticketNumArray = { 1, 0, 4, 2, 0, 3, 0, 4 };
            Assert.IsTrue(LuckyTicket.Simple(ticketNumArray));
        }

        [TestMethod()]
        public void ConvertTicketTest_5684736581_Array()
        {
            String ticketNumStr = "5684736581";
            int[] expectedResult = { 5, 6, 8, 4, 7, 3, 6, 5, 8, 1 };
            int[] actualResult = LuckyTicket.ConvertTicket(ticketNumStr);            
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}