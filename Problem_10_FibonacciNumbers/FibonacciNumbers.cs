using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
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
