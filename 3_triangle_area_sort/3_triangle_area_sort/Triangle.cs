using System;

namespace _3_triangle_area_sort
{
    public class Triangle : IComparable
    {
        double _a, _b, _c;
        public double A
        {
            get { return _a; }
            set => _a = value;
        }
        public double B
        {
            get { return _b; }
            set => _b = value;
        }
        public double C
        {
            get { return _c; }
            set => _c = value;
        }
        public string Name { get; set; }
        public double Area { get; private set; }

        public Triangle(string Name, double A, double B, double C)
        {
            this.Name = Name;
            this.A = A;
            this.B = B;
            this.C = C;
            this.Area = CalculateTriangleArea(A, B, C);
        }        

        public static double CalculateTriangleArea(double A, double B, double C)
        {
            double p = (A + B + C) / 2;
            double Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return Area;
        }

        public int CompareTo(Object obj)
        {
            Triangle tr = obj as Triangle;
            return this.Area.CompareTo(tr.Area);
        }        

        public static bool isTriangleExists(double A, double B, double C)
        {
            return (A + B > C && A + C > B && B + C > A);
        }
    }
}
