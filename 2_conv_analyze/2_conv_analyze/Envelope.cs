using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instruments;

namespace _2_conv_analyze
{
    class Envelope
    {
        private double a;
        public double A
        {
            get { return a; }
            set
            {
                if (Validator.IsPositive(value)) a = value;
            }
        }
        private double b;
        public double B
        {
            get { return b; }
            set
            {
                if (Validator.IsPositive(value)) b = value;
            }
        }

        public double Area { get; private set; }
        public Envelope() { }
        public Envelope(double A, double B)
        {
            this.A = A;
            this.B = B;
            CalcArea();
        }

        public static bool operator >(Envelope c1, Envelope c2)
        {
            bool result = (((c1.A > c2.A) && (c1.B > c2.B)) || ((c1.A > c2.B) && (c1.B > c2.A))) ? true : false;
            return result;
        }

        public static bool operator <(Envelope c1, Envelope c2)
        {
            bool result = (((c1.A < c2.A) && (c1.B < c2.B)) || ((c1.A < c2.B) && (c1.B < c2.A))) ? true : false;
            return result;
        }

        public void SetValues()
        {
            for (; ; )
            {
                try
                {
                    Console.Write("\nEnter first side: \n >> ");
                    A = Validator.ReadDouble();
                    Console.Write("Enter second side: \n >> ");
                    B = Validator.ReadDouble();
                }
                catch (Exception ex)
                {
                    Output.Message(ex.Message, ConsoleColor.Red);
                    continue;
                }
                CalcArea();
                break;
            }
        }

        private void CalcArea()
        {
            Area = A * B;
        }
    }
}
