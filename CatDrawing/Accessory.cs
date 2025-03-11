using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Accessory : Figure
    {
        public Accessory(int cursorPositionX = 0, int cursorPositionY = 0) : base(cursorPositionX, cursorPositionY) { }

        public override void Draw()
        {
            SlowDrawing("######|_| ########", cursorPositionX, cursorPositionY++);
            SlowDrawing("/+  \\ ##*", cursorPositionX + 5, cursorPositionY++);
            SlowDrawing("\\ _ / #*", cursorPositionX + 5, cursorPositionY++);
        }
    }
}
/*
######|_| ########
     /+  \ ##*
     \ _ / #*
*/