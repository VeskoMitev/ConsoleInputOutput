using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{

    /*
     * Problem 9.	* Sum of n Numbers

     * Write a program that enters a number n and after that enters 
     * more n numbers and calculates and prints their sum. 
     * Note that you may need to use a for-loop.
     * 
     */ 

     
    class Sum_of_n_Numbers
    {
        static void Main(string[] args)
        {
            int countNumber = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < countNumber; i++)
            {
                sum+=Double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);

        }
    }
}
