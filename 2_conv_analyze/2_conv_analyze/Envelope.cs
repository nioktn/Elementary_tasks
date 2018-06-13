using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instruments;

namespace _2_conv_analyze
{
    public class Envelope
    {
        private double _a;
        public double A
        {
            get { return _a; }
            set => _a = value;
        }
        private double _b;
        public double B
        {
            get { return _b; }
            set => _b = value;
        }

        public Envelope(double A, double B)
        {
            this.A = A;
            this.B = B;
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

        public static bool DiagCmp(Envelope c1, Envelope c2)
        {
            double a1 = Math.Max(c1.A, c1.B), b1 = Math.Min(c1.A, c1.B), a2 = Math.Max(c2.A, c2.B), b2 = Math.Min(c2.A, c2.B);
            if (a1 > a2)
            {
                double temp = a1;
                a1 = a2;
                a2 = temp;
                temp = b1;
                b1 = b2;
                b2 = temp;
            }
            double funcCalc = Math.Pow((a1 + b1) / (a2 + b2), 2) + Math.Pow((a1 - b1) / (a2 - b2), 2);
            return (funcCalc > 2);
        }
    }
}
