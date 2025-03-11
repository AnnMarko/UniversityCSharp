using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Tail : Figure
    {
        public Tail(int cursorPositionX = 0, int cursorPositionY = 0) : base(cursorPositionX, cursorPositionY) { }

        public override void Draw()
        {
            SlowDrawing("________", cursorPositionX + 11, cursorPositionY++);
            SlowDrawing("__-############-_", cursorPositionX + 6, cursorPositionY++);
            SlowDrawing("_###              ##_", cursorPositionX + 4, cursorPositionY++);
            SlowDrawing("-##                  #\\", cursorPositionX + 3, cursorPositionY++);
            SlowDrawing("/#                     #\\", cursorPositionX + 2, cursorPositionY++);
            SlowDrawing("/         ######         |", cursorPositionX + 1, cursorPositionY++);
            SlowDrawing("/#       ##~^^^~##       #|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|#     ##/       \\####  #/", cursorPositionX, cursorPositionY++);
            SlowDrawing("|#     #/         *#####*", cursorPositionX, cursorPositionY++);
            SlowDrawing("|#    ##|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|     ##|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|     ##|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|     ##|", cursorPositionX, cursorPositionY++);
            SlowDrawing("|    ##/", cursorPositionX, cursorPositionY++);
            SlowDrawing("|   ##/", cursorPositionX, cursorPositionY++);
            SlowDrawing("|# ##/", cursorPositionX, cursorPositionY++);
            SlowDrawing("_-", cursorPositionX + 2, cursorPositionY);
        }
    }
}
/*
           ________        
      __-############-_    
    _###              ##_  
   -##                  #\ 
  /#                     #\
 /         ######         |
/#       ##~^^^~##       #|
|#     ##/       \####  #/ 
|#     #/         *#####*  
|#    ##|                  
|     ##|                  
|     ##|                  
|     ##|                  
|    ##/                   
|   ##/                    
|# ##/                     
  _-                       
*/