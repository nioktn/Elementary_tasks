using Instruments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _8_Fibonacci_series
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                try
                {
                    Console.Write(" Select programm mode:\n1. Fibonacci series between min and max values;" +
                        "\n2. Fibonacci series for setted num length values; \n0. Exit. \n >> ");
                    int mode = Validator.ReadInt();
                    switch (mode)
                    {
                        case (1):
                            Console.Write("Enter min value: \n >> ");
                            long min = Validator.ReadLong();
                            Console.Write("Enter max value: \n >> ");
                            long max = Validator.ReadLong();
                            if (Validator.IsPositive(max)) Fibonacci.Display(Fibonacci.CalcFbnc(min, max));
                            break;
                        case (2):
                            Console.Write("Enter num lenght: \n >> ");
                            int numLength = Validator.ReadInt();
                            if (numLength <= 0 || numLength > 19) throw new Exception("Value can't be negative or bigger than 19");
                            else Fibonacci.Display(Fibonacci.CalcFbnc(numLength));
                            break;
                        case (0):
                            Environment.Exit(0);
                            break;
                        default:
                            Output.Message("There are no mode like this\n", ConsoleColor.Red);
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
