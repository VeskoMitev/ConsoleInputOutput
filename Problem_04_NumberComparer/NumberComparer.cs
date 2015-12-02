using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    class NumberComparer
    {
        /*
         *         Problem 4.	Number Comparer

         * Write a program that gets two numbers from the console and 
         * prints the greater of them. Try to implement this without 
         * if statements. 
         * 
         */ 

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Greater:{0}",(a>b)?a:b);
        }
    }
}
