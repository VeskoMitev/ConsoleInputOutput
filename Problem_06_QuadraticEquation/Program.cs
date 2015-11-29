using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06_QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter coefficient a:");
            double a = Double.Parse(Console.ReadLine());

            Console.Write("Enter coefficient b:");
            double b = Double.Parse(Console.ReadLine());

            Console.Write("Enter coefficient c:");
            double c = Double.Parse(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (discriminant > 0)
            { 
                Console.Write("x1={0};   ", (-b - Math.Sqrt(discriminant) ) / (2*a) );
                Console.WriteLine("x2={0}", (-b + Math.Sqrt(discriminant) ) / (2*a) );
            }
            else
            {
                Console.WriteLine("x1=x2={0}", (-b + Math.Sqrt(discriminant)) / (2 * a));
            }
        }
    }
}
