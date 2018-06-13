using System;
using System.Linq;
using System.Text.RegularExpressions;
using Instruments;

namespace _6_lucky_tickets
{
    public class LuckyTicket
    {
        public static bool Check_ticket_num(String str)
        {
            string pattern = @"^\d*$";
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(str);
            return (matches.Count > 0) ? ((str.Length % 2 == 0) ? true : false) : false;
        }

        private static int[] Convert_ticket(String ticket_str)
        {
            int[] int_array = new int[ticket_str.Length];
            for (int i = 0; i < ticket_str.Length; i++)
            {
                int_array[i] = (int)char.GetNumericValue(ticket_str[i]);
            }
            return int_array;
        }

        public static bool Simple(int[] mass)
        {
            int left_sum = 0, right_sum = 0, count = mass.Count() / 2;
            for (int i = 0; i < count; i++)
            {
                left_sum += mass[i];
                right_sum += mass[count + i];
            }
            return (left_sum == right_sum) ? true : false;
        }

        public static bool Complex(int[] mass)
        {
            int even_sum = 0, odd_sum = 0;
            foreach (var item in mass)
            {
                if (item % 2 == 0) even_sum += item;
                else odd_sum += item;
            }
            return (even_sum == odd_sum) ? true : false;
        }

        public static void TestMethods(String min, String max)
        {
            int count = Int32.Parse(min), simple_count = 0, complex_count = 0;
            String current = min;
            while (count != Int32.Parse(max))
            {
                if (LuckyTicket.Simple(LuckyTicket.Convert_ticket(current))) simple_count++;
                if (LuckyTicket.Complex(LuckyTicket.Convert_ticket(current))) complex_count++;
                count++;
                current = count.ToString();
            }

            Output.Message("Simple: " + simple_count + ", Complex: " + complex_count, ConsoleColor.Yellow);
        }
    }
}
