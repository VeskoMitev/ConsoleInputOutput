using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12_FallingRocks
{
    
   public class Dwarf : Symbol
   {
       
       public Dwarf()
       {
           base.SymbolDraw = "(O)";
           base.PositionX = FallingRocks.maxWidth/2;
          base.PositionY = FallingRocks.maxHeight  - 2;
           Lives = 5;
       }

      
       public int Lives { get; private set; }

       public void StartLevel()
       {
           base.SymbolDraw = "(O)";
       }
       public void Crashed()
       {
           Lives -=1;
           base.SymbolDraw = "{X}";
       }
    }
}
