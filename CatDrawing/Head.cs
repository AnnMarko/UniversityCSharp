using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Head : Figure
    {
        public Head(int cursorPositionX = 0, int cursorPositionY = 0) : base(cursorPositionX, cursorPositionY) { }

        public override void Draw()
        {
            SlowDrawing("__------------------------__", cursorPositionX + 2, cursorPositionY++);
            SlowDrawing("|#          # ##*#          #|", cursorPositionX + 1, cursorPositionY++);
            SlowDrawing("|#                            #|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|#                            #|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|#                            #|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|#                            #|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|#                          #|", cursorPositionX + 1, cursorPositionY++);
            SlowDrawing("\\#                        #/", cursorPositionX + 2, cursorPositionY++);
            SlowDrawing("--------------------------", cursorPositionX + 3, cursorPositionY);
        }
    }
}
/*
        __------------------------__                                 
       |#          # ##*#          #|                                
      |#                            #|                               
      |#                            #|                               
      |#                            #|                               
      |#                            #|             
       |#                          #|       
        \#                        #/  
         --------------------------
 */