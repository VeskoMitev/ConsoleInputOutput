using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_12_FallingRocks
{
    class FallingRocks
    {
         public  static int maxHeight = 30;
          public  static int maxWidth = 40;

        static void PrintRow(string txt, int rowPos)
        {
            Console.SetCursorPosition( maxWidth+4,rowPos );
            Console.Write(txt);
        }
        static void PrintScore(int score,int lives)
        {
            int startrow = 10;
            Console.ForegroundColor = ConsoleColor.White; 
            PrintRow("*".PadLeft(19,'*'),10);
            PrintRow(string.Format("*{0,2}Falling Rocks{0,2}*", " "), 11);
            PrintRow("*".PadLeft(19, '*'), 12);
            PrintRow(string.Format("*{0,17}*", " "), 13);
            PrintRow(string.Format("*{0,2}Резултат:{1,5}{0,1}*", " ",score), 13 );
            PrintRow(string.Format("*{0,2}Животи:{1,7}{0,1}*", " ", lives), 14);
            PrintRow("*".PadLeft(19, '*'), 15);

        }

        static void PrintField()
        {
           Console.SetCursorPosition(0,0);
            Console.Write("-".PadLeft(maxWidth+3, '-'));
            for (int i = 1; i < maxHeight-1 ; i++)
            {

                Console.SetCursorPosition(maxWidth + 2,i);
                Console.Write("|");
                Console.SetCursorPosition(0, i);
                Console.Write("|");
            }
        }
        static void Main(string[] args)
        {
            bool crash = false;
            int scoreGame = 0;
            Console.WindowWidth = maxWidth+30;
            Console.BufferWidth = maxWidth+30;
            Console.CursorVisible = false;
            Console.WindowHeight =maxHeight;
            Console.BufferHeight = maxHeight;

            Dwarf  dwarf = new Dwarf();
            dwarf.SymbolColor = ConsoleColor.Green;

            List<Rock> rocks = new List<Rock>();
            Random rand = new Random();

            while (dwarf.Lives>0)
            {
                rocks.Add(new Rock());
          
                if (Console.KeyAvailable )
                {
                    ConsoleKeyInfo pressendKey = Console.ReadKey();
                    if (pressendKey.Key == ConsoleKey.LeftArrow  )
                    {
                        if(dwarf.PositionX >=dwarf.SymbolWidth -2) 
                            dwarf.PositionX -= 1;
                    }
                    else if (pressendKey.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.PositionX< maxWidth-1   )
                            dwarf.PositionX += 1;
                    }
                }
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(false);
                }
                Thread.Sleep(250);
                Console.Clear();
                PrintField();
                crash = false;
                if (rocks.Count == 2 ) dwarf.StartLevel();
                foreach (Symbol rock1 in rocks )
                {
                    rock1.DrawSymbol();
                    if (rock1.PositionY < maxHeight - 1)
                    {
                        rock1.PositionY += 1;
                        
                    }

                    if (rock1.PositionY == maxHeight - 1)
                    {
                        if (CheckForCrash(dwarf, rock1))
                        {
                            crash = true;
                            dwarf.Crashed();
                          
                        }
                    }
                   
                }

                if (crash)
                {
                    rocks.RemoveAll(x=>x.PositionY>=0);
                }
                else
                {
                    scoreGame+= rocks.RemoveAll(x => x.PositionY > maxHeight-2 );
                }
                    
               
               
                PrintScore(scoreGame,dwarf.Lives);
                dwarf.DrawSymbol();
                
            }
        }

        private static bool CheckForCrash(Symbol  dwarf, Symbol  rock1)
        {
            if (dwarf.PositionX > rock1.PositionX)
            {
                if (rock1.PositionX+rock1.SymbolWidth>dwarf.PositionX)
                {
                    return true;
                }
            }
            else if (dwarf.PositionX < rock1.PositionX)
            {
                if (dwarf.PositionX + dwarf.SymbolWidth > rock1.PositionX)
                    return true;
            }
            else
            {
                if (dwarf.PositionX == rock1.PositionX)
                    return true;
            }
            return false;
           
        }
    }
}
