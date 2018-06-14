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
                try
                {
                    Console.Write("Enter min value:\n >> ");
                    min = Validator.ReadString();
                    Console.Write("Enter max value:\n >> ");
                    max = Validator.ReadString();
                    if (!LuckyTicket.CheckTicketNum(max) || !LuckyTicket.CheckTicketNum(min) || (Int32.Parse(min) > Int32.Parse(max)))
                    {
                        throw new Exception("Ticket has wrong format, try again\n");
                    }

                    else
                    {
                        LuckyTicket.TestMethods(min, max);
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Output.Message(ex.Message, ConsoleColor.Red);
                    continue;
                }
            }
            Console.Read();
        }

    }
}