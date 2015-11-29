using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12_FallingRocks
{
   public class Symbol
   {
       private ConsoleColor _symbolColor; 
       public Symbol():this(" ",ConsoleColor.White)
       {
            
       }
       public Symbol(string symbol):this(symbol,ConsoleColor.White)
       {
           
       }
       public Symbol(string symbol,ConsoleColor symbolcolor)
       {
          SymbolDraw = symbol;
           
           _symbolColor = symbolcolor;
       }
       
       public int PositionX { get; set; }
       public  int PositionY { get; set; }

       protected string  SymbolDraw { get; set; }

       public ConsoleColor SymbolColor
       {
           get { return _symbolColor; }
           set { _symbolColor = value; }
       }

       public int SymbolWidth
       {
           get { return SymbolDraw.Length; }
       }
       public void DrawSymbol()
       {
           Console.CursorVisible = false;
           Console.SetCursorPosition(PositionX, PositionY);
           Console.ForegroundColor = _symbolColor;
           Console.Write(SymbolDraw);
       }


    }
}
