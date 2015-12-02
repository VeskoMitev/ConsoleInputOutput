using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12_FallingRocks
{
    class Rock:Symbol 
    {
        public Rock()
        {
            char[] rock = new[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
            Random rand = new Random();
            char newRockChat = rock[rand.Next(0, rock.Length - 1)];
            string newRockString = newRockChat.ToString().PadLeft(rand.Next(1, 4), newRockChat);
            ConsoleColor symColor = ConsoleColor.Yellow; // (ConsoleColor) (rand.Next(Enum.GetNames(typeof (ConsoleColor)).Length));
            switch (newRockChat)
            {
                case '^':
                    symColor = ConsoleColor.Red;
                    break;
                case '@':
                    symColor = ConsoleColor.Cyan;
                    break;
                case '*':
                    symColor = ConsoleColor.Gray;
                    break;
                case '+':
                    symColor = ConsoleColor.Blue;
                    break;
                case '%':
                    symColor = ConsoleColor.Magenta;
                    break;
                case '$':
                    symColor = ConsoleColor.White;
                    break;
                case '&':
                    symColor = ConsoleColor.DarkGray;
                    break;
                case '!':
                    symColor = ConsoleColor.DarkYellow;
                    break;
                case '#':
                    symColor = ConsoleColor.DarkCyan;
                    break;
                case '.':
                    symColor = ConsoleColor.White;
                    break;
                case '-':
                    symColor = ConsoleColor.DarkRed;
                    break;
            }
            int symXPos =  rand.Next( 1,FallingRocks.maxWidth);//10;

            base.PositionX = symXPos;
            base.PositionY = 1;

            base.SymbolColor = symColor;
            base.SymbolDraw = newRockString;
        }
    }
}
