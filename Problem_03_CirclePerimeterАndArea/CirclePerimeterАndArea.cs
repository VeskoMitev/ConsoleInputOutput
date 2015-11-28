using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    class CirclePerimeterАndArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius of circle: ");
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2*Math.PI*radius;
            double area = Math.PI*radius*radius;

            Console.WriteLine("Perimeter:{0:F2}\nArea:{1:F2}",perimeter,area);



        }
    }
}
