using Instruments;
using System;

namespace _7_num_seq
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                try
                {
                    Console.Write("Enter num of elements >> ");
                    int N = Validator.ReadInt();
                    Console.Write("Enter minimal squared element >> ");
                    double minSqr = Validator.ReadDouble();
                    if (Validator.IsPositive(N) && Validator.IsPositive(minSqr))
                    {
                        String sequence = Sequence.GetSeqString(N, minSqr);
                        Output.Message(sequence, ConsoleColor.Yellow);
                    }
                    break;
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