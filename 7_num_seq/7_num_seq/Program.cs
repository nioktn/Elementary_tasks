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
                Console.Write("Enter num of elements:");
                int N = Validator.ReadInt2(true);
                Console.Write("Enter minimal squared element:");
                double minSqr = Validator.ReadDouble2(true);
                String sequence = Sequence.GetSeqString(N, minSqr);
                Output.Message(sequence, ConsoleColor.Yellow);
                break;
            }
            Console.Read();
        }
    }
}