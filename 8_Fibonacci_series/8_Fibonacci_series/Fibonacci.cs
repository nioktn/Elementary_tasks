using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instruments;

namespace _8_Fibonacci_series
{
    public static class Fibonacci
    {
        public static List<long> CalcFbnc(long min, long max)
        {
            List<long> sequence = new List<long> { 1, 1 };
            for (int i = 0; (sequence[i] + sequence[i + 1]) < max; i++)
            {
                sequence.Add(sequence[i] + sequence[i + 1]);
            }
            sequence.RemoveAll(x => x < min);
            return sequence;
        }

        public static List<long> CalcFbnc(long numLength)
        {
            List<long> sequence = new List<long> { 1, 1 };
            int count = 0;
            while (sequence.Last().ToString().Length <= numLength)
            {
                sequence.Add(sequence[count] + sequence[count + 1]);
                count++;
            }
            sequence.Remove(sequence.Last());
            for (int i = count; i >= 0; i--)
            {
                if (sequence[i].ToString().Length < numLength)
                {
                    sequence.RemoveAt(i);
                }
            }
            return sequence;
        }
        public static void Display(List<long> collection)
        {
            Output.Message("\n Fibonacci series output:", ConsoleColor.Yellow);
            foreach (var item in collection)
            {
                Output.Message(String.Format("  {0} ", item), ConsoleColor.Yellow);
            }
            Console.WriteLine("\n");
        }
    }
}
