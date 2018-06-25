using Instruments;
using System;
using System.Text;

namespace _5_num_in_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (; ; )
            {
                Console.Write(" Choose one option >> \n1. Enter new number\n0. Exit application\n");
                int choise = Validator.ReadInt2();
                switch (choise)
                {
                    case (1):
                        Console.Write("Enter long number \n");
                        long number = Validator.ReadLong2();
                        String str = StringNumber.CreateString(number);
                        Output.Message(String.Format("Your string: \n{0}\n", str), ConsoleColor.DarkYellow);
                        continue;
                    case (0):
                        Environment.Exit(0);
                        break;
                    default:
                        Output.Message("Wrong option", ConsoleColor.Red);
                        continue;
                }
            }
        }
    }
}
