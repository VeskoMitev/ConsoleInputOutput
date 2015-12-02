using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    /*
     * Problem 11.	* Numbers in Interval Dividable by Given Number

     * Write a program that reads two positive integer numbers and prints how 
     * many numbers p exist between them such that the reminder of the division by 5 is 0. 
     * 
     */ 

    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main(string[] args)
        {
            int firstNumber = Int32.Parse(Console.ReadLine());
            int secondNumber = Int32.Parse(Console.ReadLine());
            int num = 0;
            for (int i = firstNumber ; i <= secondNumber ; i++)
                if (i%5==0) num++;
            Console.WriteLine(num);
        }
    }
}
