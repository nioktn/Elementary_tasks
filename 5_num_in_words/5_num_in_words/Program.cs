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
                Console.Write(" Choose one option >> \n1. Enter new number\n0. Exit application\n >> ");
                try
                {
                    int choise = Validator.ReadInt();
                    switch (choise)
                    {
                        case (1):
                            Console.Write("Enter long number \n >> ");
                            long number = Validator.ReadLong();
                            String str = StringNumber.CreateString(number);
                            Output.Message("Your string: \n" + str + "\n", ConsoleColor.DarkYellow);
                            continue;
                        case (0):
                            Environment.Exit(0);
                            break;
                        default:
                            Output.Message("Wrong option", ConsoleColor.Red);
                            continue;
                    }
                }
                catch (Exception ex)
                {
                    Output.Message(ex.Message, ConsoleColor.Red);
                    continue;
                }
            }
        }
    }
}
