using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Figure
    {
        protected int cursorPositionX;
        protected int cursorPositionY;
        static int drawingSpeed = 100;

        public Figure(int cursorPositionX = 0, int cursorPositionY = 0)
        {
            if (cursorPositionX < 0)
                cursorPositionX = 0;
            if (cursorPositionY < 0)
                cursorPositionY = 0;
            this.cursorPositionX = cursorPositionX;
            this.cursorPositionY = cursorPositionY;
        }

        public void SetCursorPosition(int cursorPositionX = -1, int cursorPositionY = -1)
        {
            if (cursorPositionX >= 0)
            {
                this.cursorPositionX = cursorPositionX;
            }
            if (cursorPositionY >= 0)
            {
                this.cursorPositionY = cursorPositionY;
            }
        }

        public static void SetDrawingSpeed(int speed)
        {
            if (speed >= 0)
            {
                drawingSpeed = speed;
            }
        }

        public static int GetDrawingSpeed()
        {
            return drawingSpeed;
        }

        virtual public void Draw() { }

        protected void SlowDrawing(string str, int cursorPositionX, int cursorPositionY)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.Write(str);
            Thread.Sleep(drawingSpeed);
        }
    }
}
