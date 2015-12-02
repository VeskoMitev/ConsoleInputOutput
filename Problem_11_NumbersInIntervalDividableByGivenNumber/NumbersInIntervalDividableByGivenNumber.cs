using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
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
