using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instruments;

namespace _3_triangle_area_sort
{
    class Triangle : IComparable
    {
        double a, b, c;
        public string Name { get; set; }
        public double A
        {
            get { return a; }
            set
            {
                if (Validator.IsPositive(value)) a = value;
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (Validator.IsPositive(value)) b = value;
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (Validator.IsPositive(value)) c = value;
            }
        }
        public double Area { get; private set; }

        private void CalculateArea()
        {
            if (A + B > C && A + C > B && B + C > A)
            {
                double p = (A + B + C) / 2;
                Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("Triangle can`t exist");
            }
        }

        public int CompareTo(object obj)
        {
            Triangle t = (Triangle)obj;
            if (t != null)
                return this.Area.CompareTo(t.Area);
            else
                throw new Exception("Can`t be compared");
        }

        public Triangle(string Name, double A, double B, double C)
        {
            this.Name = Name;
            this.A = A;
            this.B = B;
            this.C = C;
            CalculateArea();
        }
    }
}
