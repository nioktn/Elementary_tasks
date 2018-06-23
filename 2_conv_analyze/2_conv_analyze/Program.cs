using Instruments;
using System;

namespace _2_conv_analyze
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string answer;
            for (; ; )
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
                else Environment.Exit(0);
            }
        }
        public static Envelope CreateEnvelope()
        {
            Console.Write("\nEnter first side: \n");
            double side1 = Validator.ReadDouble2(true);
            Console.Write("\nEnter second side: \n");
            double side2 = Validator.ReadDouble2(true);
            return new Envelope(side1, side2);
        }
    }
}
