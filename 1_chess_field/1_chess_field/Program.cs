using Instruments;
using System;

namespace _1_chess_field
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            char agr = '*';
            Console.Write("Enter height: \n");
            int height = Validator.ReadInt2(true);
            Console.Write("\nEnter width: \n");
            int width = Validator.ReadInt2(true);
            Console.Write("\nEnter aggregator: \n");
            agr = Validator.ReadChar2();
            ChessGrid cg = new ChessGrid(height, width, agr);
            Output.Message("\n" + cg.GetGrid(), ConsoleColor.Yellow);
            Console.ReadKey();
        }
    }
}