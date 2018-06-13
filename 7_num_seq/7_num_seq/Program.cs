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
                    double MinSqr = Validator.ReadDouble();
                    Sequence seq1 = new Sequence(N, MinSqr);
                    Console.WriteLine(seq1.SeqStr);
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
