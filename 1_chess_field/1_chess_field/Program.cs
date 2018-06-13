using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instruments;

namespace _1_chess_field
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            int height = 0, width = 0;
            char agr = '*';
            for (; ; )
            {
                try
                {
                    Console.Write("Enter height: \n >> ");
                    height = Validator.ReadInt();
                    Console.Write("\nEnter width: \n >> ");
                    width = Validator.ReadInt();
                    Console.Write("\nEnter aggregator: \n >> ");
                    agr = Validator.ReadChar();
                    ChessGrid cg = new ChessGrid(height, width, agr);
                    Output.Message("\n" + cg.GetGrid(), ConsoleColor.Yellow);
                    break;
                }

                catch (Exception ex)
                {
                    Output.Message(ex.Message, ConsoleColor.Red);
                    Environment.Exit(0);
                }
            }
            Console.ReadKey();
        }
    }
}
