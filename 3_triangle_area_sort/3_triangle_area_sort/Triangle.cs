using System;

namespace _3_triangle_area_sort
{
    public class Triangle : IComparable
    {
        double _a, _b, _c;
        public string Name { get; set; }
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
        public double Area { get; private set; }

        public static double CalculateTriangleArea(double A, double B, double C)
        {
            double p = (A + B + C) / 2;
            double Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return Area;
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
            this.Area = CalculateTriangleArea(A, B, C);
        }

        public static bool isTriangleExists(double A, double B, double C)
        {
            return (A + B > C && A + C > B && B + C > A);
        }
    }
}
