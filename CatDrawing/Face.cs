using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Face : Figure
    {
        public Face(int cursorPositionX = 0, int cursorPositionY = 0) : base(cursorPositionX, cursorPositionY) { }

        public override void Draw()
        {
            SlowDrawing("####          ####", cursorPositionX + 1, cursorPositionY++);
            SlowDrawing("#  ###        #  ###", cursorPositionX, cursorPositionY++);
            SlowDrawing("####          ####", cursorPositionX + 1, cursorPositionY++);
            SlowDrawing("____ ###  ____", cursorPositionX + 3, cursorPositionY++);
            SlowDrawing("---  #   ---", cursorPositionX + 4, cursorPositionY);
        }
    }
}
/*
 ####          #### 
#  ###        #  ###           
 ####          ####
   ____ ###  ____
    ---  #   ---
*/