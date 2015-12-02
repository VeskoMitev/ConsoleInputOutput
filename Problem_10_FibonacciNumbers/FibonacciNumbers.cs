using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    /*
     * Problem 10.	 * Fibonacci Numbers

     * Write a program that reads a number n and prints on the console 
     * the first n members of the Fibonacci sequence 
     * (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
     * Note that you may need to learn how to use loops. 
     * 
     */ 

    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int countNumber = Int32.Parse(Console.ReadLine());

            int first = 0;
            int secount = 1;
            Console.Write("0 1 ");
            for (int i = 2; i < countNumber; i++)
            {
                int num = secount + first;
                Console.Write("{0} ", num);
                first = secount;
                secount =num;
                
            }
            Console.WriteLine();

        }
    }
}
