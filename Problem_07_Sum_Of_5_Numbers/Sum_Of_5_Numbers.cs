using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    class Sum_Of_5_Numbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sumOfNumbers  = input.Split(' ').Select(x => Convert.ToDouble(x)).Sum();
            Console.WriteLine(sumOfNumbers);
        }
    }
}
