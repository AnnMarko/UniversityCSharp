using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Cat : Figure
    {
        public Cat(int cursorPositionX = 0, int cursorPositionY = 0) : base(cursorPositionX, cursorPositionY) { }

        public override void Draw()
        {
            Figure figure = new Head(cursorPositionX + 6, cursorPositionY + 5);
            figure.Draw();
            figure = new Ears(cursorPositionX + 8, cursorPositionY);
            figure.Draw();
            figure = new Body(cursorPositionX + 4, cursorPositionY + 14);
            figure.Draw();
            figure = new Paws(cursorPositionX, cursorPositionY + 19);
            figure.Draw();
            figure = new Tail(cursorPositionX + 42, cursorPositionY + 10);
            figure.Draw();
            figure = new Face(cursorPositionX + 12, cursorPositionY + 8);
            figure.Draw();
            figure = new Accessory(cursorPositionX + 14, cursorPositionY + 15);
            figure.Draw();
        }
    }
}

/*
            ___              ___                                     
           /#  \            /  #\                                    
          /#    \          /    #\                                   
         /##     \        /     ##\                                  
        |###      \      /      ###|                                 
        |####     |------|     ####|                                 
       |#          # ##*#          #|                                
      |#                            #|                               
      |#     ####          ####     #|                               
      |#    #  ###        #  ###    #|                               
      |#     ####          ####     #|               ________        
       |#      ____ ###  ____      #|           __-############-_    
        \#      ---  #   ---      #/          _###              ##_  
         --------------------------          -##                  #\ 
        |__________________________|        /#                     #\
       /#     ######|_| ########   #\      /         ######         |
      /##          /+  \ ##*       ##\    /#       ##~^^^~##       #|
     /##           \ _ / #*         ##\   |#     ##/       \####  #/ 
    |##                              ##|  |#     #/         *#####*  
    |##    \                    /    ##|  |#    ##|                  
  _-|#               # *             ##|-_|     ##|                  
 |# |#      |      #|**|#     #|   *###|##|     ##|                  
 |# |#     *|      #|**|#     #|   ####|##|     ##|                  
 |# |#     #|      #|**|#     #|   ####|##|    ##/                   
 |# |#     #|      #|**|#     #|   ####|##|   ##/                    
 |# _#_    #|      #|**|#     #|   ##_#|##|# ##/                     
|#    *|   #-       -__-       -  *#|**   #|_-                       
|###   |-__|        #||#       #|__-|*  ###|                         
 ##___-     --__ __--  --__ __--     -#####                          
*/