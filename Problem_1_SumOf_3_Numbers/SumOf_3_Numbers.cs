namespace ConsoleInputOutput
{
    using System;
    class SumOf_3_Numbers
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}", firstNumber + secondNumber + thirdNumber);
        }
    }
}
