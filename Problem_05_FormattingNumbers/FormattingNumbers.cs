using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.Write("|{0,-10:X2}|{1}|", firstNumber, Convert.ToString(firstNumber, 2).PadLeft(10, '0'));
            Console.WriteLine("{0,10:N2}|{1,-10:N3}|",secondNumber,thirdNumber );


        }
    }
}
