namespace ConsoleInputOutput
{
    using System;
    class MagicWand
    {
        static void Main(string[] args)
        {
            var n = byte.Parse(Console.ReadLine());

            int width = (n*3) + 2;
            int center = width/2;
            int tmp = center;
            do
            {
                for (int i = 0; i < width; i++)
                {
                    if (center - (center - tmp) == i || center + (center - tmp) == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                       Console.Write(".");  
                    }
                   
                }
                Console.WriteLine();
                tmp--;
            } while (tmp>n-1);

            //*********************
            for (int i = 0; i < width; i++)
            {
                if (i < n  || i > (n * 2) + 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }

            //****************************
            Console.WriteLine();
            tmp = 1;
            do
            {
                for (int i = 0; i < width ; i++)
                {
                    if (tmp==i || i==width-tmp-1)
                    {
                        Console.Write("*"); 
                    }
                    else
                    {
                     Console.Write(".");   
                    }
                    
                }
                Console.WriteLine();
                tmp++;
            } while (tmp < (n/2)+1);
            tmp = (n / 2)-1 ;
            do
            {
                for (int i = 0; i < width; i++)
                {
                    if (tmp == i || tmp + ((n / 2) + 1) == i || i == width - tmp - 1 || i == width - tmp - 1 - ((n / 2) + 1) || i == n || i == (n * 2) + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                Console.WriteLine();
                tmp--;
            } while (tmp >=  0);

            for (int i = 0; i < width ; i++)
            {
                if ((i<(n/2)+1)|| i>= width -((n/2)+1)|| i==n||i==(n*2)+1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j==n||j==(n*2)+1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
              Console.WriteLine();  
            }
            for (int i = 0; i < width ; i++)
            {
                if (i> n-1 && i <= (n * 2) +1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                } 
            }
            Console.WriteLine();
        }
    }
}
