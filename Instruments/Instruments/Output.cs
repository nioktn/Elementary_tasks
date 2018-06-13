using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public static class Output
    {
        public static void Message(String msg, ConsoleColor clr)
        {
            Console.ForegroundColor = clr;
            Console.WriteLine(msg + "\n");
            Console.ResetColor();
        }
    }
}
