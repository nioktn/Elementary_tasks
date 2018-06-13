using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instruments;

namespace _2_conv_analyze
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Envelope[] envs = new Envelope[1];
            for (; ; )
            {
                try
                {
                    Console.Write(" First: ");
                    Envelope first = CreateEnvelope();
                    Console.Write("\n Second: ");
                    Envelope second = CreateEnvelope();
                    if (first > second || first < second || Envelope.DiagCmp(first, second))
                        Output.Message("Can be enclosed", ConsoleColor.Yellow);
                    else
                        Output.Message("Can`t be enclosed", ConsoleColor.Yellow);

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
        public static Envelope CreateEnvelope()
        {
            double side1 = 0, side2 = 0, value;
            Console.Write("\nEnter first side: \n >> ");
            value = Validator.ReadDouble();
            if (Validator.IsPositive(value)) side1 = value;
            Console.Write("\nEnter second side: \n >> ");
            value = Validator.ReadDouble();
            if (Validator.IsPositive(value)) side2 = value;
            return new Envelope(side1, side2);
        }
    }
}
