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
                Console.Write(" Select programm mode:\n1. Fibonacci series between min and max values;" +
                    "\n2. Fibonacci series for setted num length values; \n0. Exit. \n");
                int mode = Validator.ReadInt2();
                switch (mode)
                {
                    case (1):
                        Console.Write("Enter min value: \n");
                        long min = Validator.ReadLong2();
                        Console.Write("Enter max value: \n");
                        long max = Validator.ReadLong2(true);
                        Fibonacci.Display(Fibonacci.CalcFbnc(min, max));
                        break;
                    case (2):
                        Console.Write("Enter num lenght: \n");
                        int numLength = Validator.ReadInt2(true);
                        if (numLength > 19) Output.Message("Value can't be bigger than 19", ConsoleColor.Red);
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
        }
    }
}
