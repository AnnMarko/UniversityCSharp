/*
    Побудувати ієрархію класів для побудови зображення, заданого умовою
    варіанта (Кіт). При побудові власної ієрархії дотримуватися принципів інкапсуляції,
    успадкування та поліморфізму. Для закритих даних-членів використовувати
    відкриті властивості. У користувацькому інтерфейсі головної функції додатка
    передбачити таку функціональну можливість: зображення з'являється на консолі
    в місці, координати якого задає користувач.
*/

using System.Text;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int x, y, time;

            while (true)
            {
                //Console.WriteLine(Console.BufferWidth);
                //Console.WriteLine(Console.BufferHeight);

                PrettyInput("Введіть положення малюнка по x: ", out x);
                while (x > Console.BufferWidth - 70 || x < 0)
                {
                    RemoveRow();
                    PrettyInput("Введіть положення малюнка по x: ", out x);
                }
                PrettyInput("Введіть положення малюнка по y: ", out y);
                while (y > Console.BufferHeight - 29 || y < 0)
                {
                    RemoveRow();
                    PrettyInput("Введіть положення малюнка по y: ", out y);
                }
                PrettyInput("Введіть час малювання одного елемента у мілісекундах (0 - за замовчуванням): ", out time);
                while (time > 10000 || time < 0)
                {
                    RemoveRow();
                    PrettyInput("Введіть час малювання одного елемента у мілісекундах (0 - за замовчуванням): ", out time);
                }

                if (time != 0)
                {
                    Figure.SetDrawingSpeed(time);
                }
                Console.CursorVisible = false;
                Cat cat = new Cat(x, y);

                cat.Draw();

                Console.ReadKey();
                Console.CursorVisible = true;
                Console.Clear();
            }
        }

        static void PrettyInput(string output, out int variable)
        {
            Console.Write(output);
            while (!int.TryParse(Console.ReadLine(), out variable))
            {
                RemoveRow();
                Console.Write(output);
            }
        }

        static void RemoveRow()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
}
