using Instruments;
using System;
using System.Text.RegularExpressions;

namespace _6_lucky_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\d*$";
            Regex rgx = new Regex(pattern);
            String min, max;
            for (; ; )
            {
                Console.Write("Enter min value:\n >> ");
                min = Validator.ReadString();
                Console.Write("Enter max value:\n >> ");
                max = Validator.ReadString();
                if (!LuckyTicket.CheckTicketNum(max) || !LuckyTicket.CheckTicketNum(min) || (Int32.Parse(min) > Int32.Parse(max)))
                {
                    Output.Message("Ticket has wrong format, try again\n", ConsoleColor.Red);
                    continue;
                }
                else
                {
                    LuckyTicket.TestMethods(min, max);
                    break;
                }
            }
            Console.Read();
        }
    }
}