using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Paws : Figure
    {
        public Paws(int cursorPositionX = 0, int cursorPositionY = 0) : base(cursorPositionX, cursorPositionY) { }

        public override void Draw()
        {
            int cursorPositionY2 = cursorPositionY + 1;
            int cursorPositionY3 = cursorPositionY + 1;

            SlowDrawing("_-", cursorPositionX + 2, cursorPositionY2++);
            SlowDrawing("|# ", cursorPositionX + 1, cursorPositionY2++);
            SlowDrawing("|# ", cursorPositionX + 1, cursorPositionY2++);
            SlowDrawing("|# ", cursorPositionX + 1, cursorPositionY2++);
            SlowDrawing("|# ", cursorPositionX + 1, cursorPositionY2++);
            SlowDrawing("|# _#_", cursorPositionX + 1, cursorPositionY2++);
            SlowDrawing("|#    *|", cursorPositionX, cursorPositionY2++);
            SlowDrawing("|###   |", cursorPositionX, cursorPositionY2++);
            SlowDrawing("##___-", cursorPositionX + 1, cursorPositionY2);


            SlowDrawing("\\                    /", cursorPositionX + 11, cursorPositionY++);
            SlowDrawing("# *", cursorPositionX + 21, cursorPositionY++);
            SlowDrawing("|      #|**|#     #|", cursorPositionX + 12, cursorPositionY++);
            SlowDrawing("*|      #|**|#     #|", cursorPositionX + 11, cursorPositionY++);
            SlowDrawing("#|      #|**|#     #|", cursorPositionX + 11, cursorPositionY++);
            SlowDrawing("#|      #|**|#     #|", cursorPositionX + 11, cursorPositionY++);
            SlowDrawing("#|      #|**|#     #|", cursorPositionX + 11, cursorPositionY++);
            SlowDrawing("#-       -__-       -", cursorPositionX + 11, cursorPositionY++);
            SlowDrawing("|        #||#       #|", cursorPositionX + 11, cursorPositionY++);
            SlowDrawing("--__ __--  --__ __--", cursorPositionX + 12, cursorPositionY);

            SlowDrawing("-_", cursorPositionX + 40, cursorPositionY3++);
            SlowDrawing("##|", cursorPositionX + 40, cursorPositionY3++);
            SlowDrawing("##|", cursorPositionX + 40, cursorPositionY3++);
            SlowDrawing("##|", cursorPositionX + 40, cursorPositionY3++);
            SlowDrawing("##|", cursorPositionX + 40, cursorPositionY3++);
            SlowDrawing("_#|##|", cursorPositionX + 37, cursorPositionY3++);
            SlowDrawing("|**   #|", cursorPositionX + 36, cursorPositionY3++);
            SlowDrawing("|*  ###|", cursorPositionX + 36, cursorPositionY3++);
            SlowDrawing("-#####", cursorPositionX + 37, cursorPositionY3);
        }
    }
}
/*
           \                    /       
  _-                 # *                -_
 |#         |      #|**|#     #|        ##|
 |#        *|      #|**|#     #|        ##|
 |#        #|      #|**|#     #|        ##|
 |#        #|      #|**|#     #|        ##|
 |# _#_    #|      #|**|#     #|     _#|##|
|#    *|   #-       -__-       -    |**   #|       
|###   |   |        #||#       #|   |*  ###|                         
 ##___-     --__ __--  --__ __--     -#####                          
*/