using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instruments;

namespace _2_conv_analyze
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            for (; ; )
            {
                try
                {
                    Console.Write(" First: ");
                    Envelope first = new Envelope();
                    first.SetValues();
                    Console.Write(" Second: ");
                    Envelope second = new Envelope();
                    second.SetValues();

                    if (first > second || first < second)
                        Console.WriteLine("Can be enclosed");
                    else
                        Console.WriteLine("Can`t be enclosed");

                    Console.Write("Do you wanna continue ? \n >> ");
                    answer = Validator.ReadString().ToLower().Trim();
                    if (answer.Equals("y") || answer.Equals("yes"))
                    {
                        Console.WriteLine("\n");
                        continue;
                    }
                    else
                        Environment.Exit(0);
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
