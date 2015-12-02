using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
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
