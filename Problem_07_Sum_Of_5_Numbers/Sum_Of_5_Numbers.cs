using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    class Sum_Of_5_Numbers
    {
        /*
         *      Problem 7.	* Sum of 5 Numbers

         * Write a program that enters 5 numbers (given in a single line, separated by a space),
         * calculates and prints their sum
         */ 

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sumOfNumbers  = input.Split(' ').Select(x => Convert.ToDouble(x)).Sum();
            Console.WriteLine(sumOfNumbers);
        }
    }
}
