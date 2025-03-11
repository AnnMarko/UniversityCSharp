using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Ears : Figure
    {
        public Ears(int cursorPositionX = 0, int cursorPositionY = 0) : base(cursorPositionX, cursorPositionY) { }
        public override void Draw()
        {
            int cursorPositionY2 = cursorPositionY;
            SlowDrawing("___", cursorPositionX + 4, cursorPositionY++);
            SlowDrawing("/#  \\", cursorPositionX + 3, cursorPositionY++);
            SlowDrawing("/#    \\", cursorPositionX + 2, cursorPositionY++);
            SlowDrawing("/##     \\", cursorPositionX + 1, cursorPositionY++);
            SlowDrawing("|###      \\", cursorPositionX, cursorPositionY++);
            SlowDrawing("|###      |", cursorPositionX, cursorPositionY);

            SlowDrawing("___", cursorPositionX + 21, cursorPositionY2++);
            SlowDrawing("/  #\\", cursorPositionX + 20, cursorPositionY2++);
            SlowDrawing("/    #\\", cursorPositionX + 19, cursorPositionY2++);
            SlowDrawing("/     ##\\", cursorPositionX + 18, cursorPositionY2++);
            SlowDrawing("/      ###|", cursorPositionX + 17, cursorPositionY2++);
            SlowDrawing("|      ###|", cursorPositionX + 17, cursorPositionY2);
        }
    }
}
/*
    ___              ___
   /#  \            /  #\
  /#    \          /    #\
 /##     \        /     ##\
|###      \      /      ###|
|###      |      |      ###|
*/