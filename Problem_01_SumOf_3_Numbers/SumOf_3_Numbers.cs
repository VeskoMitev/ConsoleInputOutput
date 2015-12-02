namespace ConsoleInputOutput
{
    using System;
    class SumOf_3_Numbers
    {
        static void Main(string[] args)
        {
            /*
             *     Problem 1.	Sum of 3 Numbers
             *     
             * Write a program that reads 3 real numbers
             * from the console and prints their sum. 
             * 
             */
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}", firstNumber + secondNumber + thirdNumber);

        }
    }
}
