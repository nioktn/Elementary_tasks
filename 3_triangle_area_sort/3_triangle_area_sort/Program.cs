using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instruments;

namespace _3_triangle_area_sort
{
    class Program
    {
        static List<Triangle> Triangles = new List<Triangle>();
        static void Main(string[] args)
        {
            String answer, trianglestr;
            for (; ; )
            {
                Console.Write(" New triangle: \nEnter string: \n >> ");
                trianglestr = Validator.ClearString(Validator.ReadString());
                String[] substrings = trianglestr.Split(',');

                try
                {
                    String Name = substrings[0].ToString();
                    double a = double.Parse(substrings[1]);
                    double b = double.Parse(substrings[2]);
                    double c = double.Parse(substrings[3]);
                    Triangle triangle = new Triangle(Name, a, b, c);
                    Triangles.Add(triangle);
                }
                catch (Exception ex)
                {
                    Output.Message(ex.Message + "\n", ConsoleColor.Red);
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

        public static void Display()
        {
            Console.WriteLine("\n========== Triangles List ===========");
            int count = 1;
            foreach (var item in Triangles)
            {
                Console.WriteLine("{0}. [Triangle {1}]: {2} cm^2)", count, item.Name, Math.Round(item.Area, 2));
                count++;
            }
        }
    }
}
