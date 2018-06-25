using System;
using System.Linq;
using System.Text.RegularExpressions;
using Instruments;

namespace _6_lucky_tickets
{
    public class LuckyTicket
    {
        public static bool CheckTicketNum(String str)
        {
            string pattern = @"^\d*$";
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(str);
            return (matches.Count > 0) ? ((str.Length % 2 == 0) ? true : false) : false;
        }

        public static int[] ConvertTicket(String ticketStr)
        {
            int[] intArray = new int[ticketStr.Length];
            for (int i = 0; i < ticketStr.Length; i++)
            {
                intArray[i] = (int)char.GetNumericValue(ticketStr[i]);
            }
            return intArray;
        }

        public static bool Simple(int[] mass)
        {
            int leftSum = 0, rightSum = 0, count = mass.Count() / 2;
            for (int i = 0; i < count; i++)
            {
                leftSum += mass[i];
                rightSum += mass[count + i];
            }
            return (leftSum == rightSum) ? true : false;
        }

        public static bool Complex(int[] mass)
        {
            int evenSum = 0, oddSum = 0;
            foreach (var item in mass)
            {
                if (item % 2 == 0) evenSum += item;
                else oddSum += item;
            }
            return (evenSum == oddSum) ? true : false;
        }

        public static void TestMethods(String min, String max)
        {
            int count = Int32.Parse(min), simpleCount = 0, complexCount = 0;
            String current = min;
            while (count != Int32.Parse(max))
            {
                if (LuckyTicket.Simple(LuckyTicket.ConvertTicket(current))) simpleCount++;
                if (LuckyTicket.Complex(LuckyTicket.ConvertTicket(current))) complexCount++;
                count++;
                current = count.ToString();
            }
            Output.Message("Simple: " + simpleCount + ", Complex: "
                + complexCount + (simpleCount > complexCount ? "\nSimple wins!" : "\nComplex wins!"),
                ConsoleColor.Yellow);
        }
    }
}
