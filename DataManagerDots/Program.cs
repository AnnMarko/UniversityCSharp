/*
    Створити клас точок у просторі, який містить закриті дані-члени координати
    x, y і z, має перевантажені конструктори, включаючи конструктор за
    замовчуванням (стандартний). Містить відкриті властивості для доступу до
    закритих полів. Має методи переміщення точки по осях X, Y і Z, визначення
    відстані до початку координат, відстані між двома точками, перетворення у
    сферичні координати, знаходження координат точок, симетричних до заданої
    відносно площин XY, YZ і XZ, осей X, Y і Z. У головній функції додатка
    створювати об'єкти, в кількості необхідній користувачеві, за допомогою
    різних конструкторів, і вивести на екран інформацію необхідну користувачеві.
    Створені об'єкти зберегти у файлі після завершення роботи програми.
*/

using System.Text;
using System.Text.Json;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string options = @"1) Переміщення
2) Визначити відстань до початку координат
3) Визначити відстань між двома точками
4) Перетворити координати у сферичні
5) Знайти координати симетричних точок
0) Назад

Ваш вибір: ";

            Dot[] loadedDots = null;
            bool withLoadedDots = false;

            if (File.Exists("dots.json"))
            {
                string jsonFromFile = File.ReadAllText("dots.json");
                if (!String.IsNullOrEmpty(jsonFromFile))
                {
                    int loadDots;
                    do
                    {
                        Console.Clear();
                        PrettyInput("У Вас є збережені точки, бажаєте завантажити їх (1) або перезаписати (0)?: ", out loadDots);
                    } while (loadDots < 0 || loadDots > 1);

                    if (loadDots == 1)
                    {
                        loadedDots = JsonSerializer.Deserialize<Dot[]>(jsonFromFile);
                    }
                }
            }
            else
            {
                File.Create("dots.json").Close();
            }

            int extraSpace;
            if (loadedDots == null || loadedDots.Length == 0)
            {
                extraSpace = 0;
            }
            else
            {
                extraSpace = loadedDots.Length;
                withLoadedDots = true;
            }

            int dotsCount;
            do
            {
                Console.Clear();
                PrettyInput("Введіть кількість потрібних точок: ", out dotsCount);
                if (withLoadedDots && dotsCount == 0)
                {
                    break;
                }
            } while (dotsCount <= 0);

            dotsCount += extraSpace;

            Dot[] dots = new Dot[dotsCount];

            Console.Clear();

            if (withLoadedDots)
            {
                for (int i = 0; i < extraSpace; i++)
                {
                    dots[i] = loadedDots[i];
                }
                ShowAllDots(dots);
            }

            for (int i = extraSpace; i < dotsCount; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Точка №{i + 1} з {dotsCount}");
                Console.WriteLine("");

                Console.WriteLine("Введіть координати (натисніть Enter для значення за замовчуванням)");
                string x = PrettyInputWithEmptyString("X: ");
                string y = PrettyInputWithEmptyString("Y: ");
                string z = PrettyInputWithEmptyString("Z: ");

                Dot dot = new Dot();
                if (!String.IsNullOrEmpty(x))
                    dot.MoveX(Convert.ToInt32(x));
                if (!String.IsNullOrEmpty(y))
                    dot.MoveY(Convert.ToInt32(y));
                if (!String.IsNullOrEmpty(z))
                    dot.MoveZ(Convert.ToInt32(z));

                dots[i] = dot;

                Console.Clear();
                ShowAllDots(dots);
            }

            string json = JsonSerializer.Serialize(dots, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText("dots.json", json);

            while (true)
            {
                int dotNumber;
                do
                {
                    Console.Clear();
                    ShowAllDots(dots);
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine();

                    PrettyInput("Оберіть номер точки (0 - вийти з програми): ", out dotNumber);
                } while (dotNumber < 0 || dotNumber > dotsCount);

                if (dotNumber == 0)
                {
                    return;
                }

                dotNumber--;

                Console.Clear();

                DotManage(dots, dotNumber, options);
            }
        }

        static void DotManage(Dot[] dots, int dotNumber, string options)
        {
            while (true)
            {
                Console.WriteLine("--------- Ваша точка ---------");
                Console.WriteLine();
                dots[dotNumber].ShowCoordinates();

                int option;
                do
                {
                    PrettyInput(options, out option, 7);
                } while (option < 0 && option <= 5);

                Console.Clear();
                Console.WriteLine("--------- Ваша точка ---------");
                Console.WriteLine();
                dots[dotNumber].ShowCoordinates();

                switch (option)
                {
                    case 0:
                        return;
                    case 1:
                        MoveDot(dots[dotNumber]);
                        string json = JsonSerializer.Serialize(dots, new JsonSerializerOptions
                        {
                            WriteIndented = true
                        });

                        File.WriteAllText("dots.json", json);
                        break;
                    case 2:
                        Console.WriteLine($"Відстань до початку координат: {Math.Round(dots[dotNumber].DistanceToOrigin(), 2)}");
                        Console.WriteLine();
                        break;
                    case 3:
                        ShowDistanceToDot(dots, dotNumber);
                        break;
                    case 4:
                        dots[dotNumber].ShowSphericalCoordinates();
                        break;
                    case 5:
                        dots[dotNumber].ShowSymetricalDots();
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("натисніть будь-яку клавішу...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ShowDistanceToDot(Dot[] dots, int dotNumber)
        {
            int dotToCompareNumber;
            do
            {
                Console.Clear();
                ShowAllDots(dots);
                PrettyInput("До якої точки знайти відстань?: ", out dotToCompareNumber);
                dotToCompareNumber--;
            } while (dotToCompareNumber < 0 || dotToCompareNumber >= dots.Length);

            Console.Clear();

            Console.WriteLine($"Точка {dotNumber + 1})");
            dots[dotNumber].ShowCoordinates();

            Console.WriteLine($"Точка {dotToCompareNumber + 1})");
            dots[dotToCompareNumber].ShowCoordinates();

            Console.WriteLine($"Відстань між ними: {Math.Round(dots[dotNumber].DistanceToDot(dots[dotToCompareNumber]), 2)}");
            Console.WriteLine();
        }
        static void MoveDot(Dot dot)
        {
            Console.WriteLine("На скільки перемістити точку по кожній з координат? (натисніть Enter, якщо переміщення не потрібне)");
            string x = PrettyInputWithEmptyString("X: ");
            string y = PrettyInputWithEmptyString("Y: ");
            string z = PrettyInputWithEmptyString("Z: ");

            if (!String.IsNullOrEmpty(x))
                dot.MoveX(Convert.ToInt32(x));
            if (!String.IsNullOrEmpty(y))
                dot.MoveY(Convert.ToInt32(y));
            if (!String.IsNullOrEmpty(z))
                dot.MoveZ(Convert.ToInt32(z));
        }

        static void ShowAllDots(Dot[] dots)
        {
            Console.WriteLine("--------- Всі точки ---------");
            Console.WriteLine();
            for (int i = 0; i < dots.Length; i++)
            {
                if (dots[i] == null)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Точок немає");
                    }
                    break;
                }
                Console.Write($"Точка {i + 1}) ");
                dots[i].ShowCoordinates();
            }
        }

        static void PrettyInput(string output, out int variable, int rows = 0)
        {
            Console.Write(output);
            while (!int.TryParse(Console.ReadLine(), out variable))
            {
                Console.SetCursorPosition(0, Console.CursorTop - (1 + rows));

                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop);

                Console.Write(output);
            }
        }

        static string PrettyInputWithEmptyString(string output)
        {
            Console.Write(output);
            string input = Console.ReadLine().Trim();
            while (!String.IsNullOrEmpty(input) && !int.TryParse(input, out int number))
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop);

                Console.Write(output);
                input = Console.ReadLine().Trim();
            }
            return input;
        }
    }
}
