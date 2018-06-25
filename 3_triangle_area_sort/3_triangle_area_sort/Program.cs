using Instruments;
using System;
using System.Collections.Generic;

namespace _3_triangle_area_sort
{
    class Program
    {
        static List<Triangle> Triangles = new List<Triangle>();
        static void Main(string[] args)
        {
            String answer;
            Output.Message("*Pattern: \"Name, side1, side2, side3\"", ConsoleColor.Cyan);
            for (; ; )
            {
                try
                {
                    Triangles.Add(GetTriangle());
                }
                catch (Exception ex)
                {
                    Output.Message(ex.Message, ConsoleColor.Red);
                    continue;
                }
                Console.Write("Do you wanna continue ? \n >> ");
                answer = Validator.ClearString(Validator.ReadString()).ToLower();
                if (answer.Equals("y") || answer.Equals("yes"))
                {
                    Console.WriteLine("\n");
                    continue;
                }
                else
                {
                    Triangles.Sort();
                    Triangles.Reverse();
                    Display();
                    Console.Read();
                    Environment.Exit(0);
                }
            }
        }

        public static Triangle GetTriangle()
        {
            String trianglestr;
            Console.Write(" New triangle: \nEnter string via pattern: \n >> ");
            trianglestr = Validator.ClearString(Validator.ReadString());
            String[] substrings = trianglestr.Split(',');
            String Name = substrings[0].ToString();
            double a = double.Parse(substrings[1]);
            double b = double.Parse(substrings[2]);
            double c = double.Parse(substrings[3]);
            if (Triangle.isTriangleExists(a, b, c)) return new Triangle(Name, a, b, c);
            else
            {
                throw new Exception("Triangle with entered sides can`t exist");
            }
        }

        public static void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n========== Triangles List ===========");
            int count = 1;
            foreach (var item in Triangles)
            {
                Console.WriteLine("{0}. [Triangle {1}]: {2} cm^2)", count, item.Name, Math.Round(item.Area, 2));
                count++;
            }
            Console.ResetColor();
        }
    }
}
