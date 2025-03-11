using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Body : Figure
    {
        public Body(int cursorPositionX = 0, int cursorPositionY = 0) : base(cursorPositionX, cursorPositionY) { }

        public override void Draw()
        {
            SlowDrawing("|__________________________|", cursorPositionX + 4, cursorPositionY++);
            SlowDrawing("/#                          #\\", cursorPositionX + 3, cursorPositionY++);
            SlowDrawing("/##                          ##\\", cursorPositionX + 2, cursorPositionY++);
            SlowDrawing("/##                            ##\\", cursorPositionX + 1, cursorPositionY++);
            SlowDrawing("|##                              ##|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|##                              ##|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|#                               ##|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|#                             *###|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|#                             ####|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|#                             ####|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|#                             ####|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|#                             ####|", cursorPositionX, cursorPositionY++);
            SlowDrawing("-                                -", cursorPositionX + 1, cursorPositionY++);
            SlowDrawing("--__________________________--", cursorPositionX + 3, cursorPositionY);
        }
    }
}
/*
    |__________________________|    
   /#                          #\   
  /##                          ##\  
 /##                            ##\ 
|##                              ##|
|##                              ##|
|#                               ##|
|#                             *###|
|#                             ####|
|#                             ####|
|#                             ####|
|#                             ####|
 -                                - 
   --__________________________--   
*/