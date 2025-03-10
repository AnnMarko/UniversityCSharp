using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Dot
    {
        private double _x, _y, _z;

        public double X
        {
            get { return _x; }
            private set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            private set { _y = value; }
        }

        public double Z
        {
            get { return _z; }
            private set { _z = value; }
        }

        public Dot(double x = 0, double y = 0, double z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void ShowCoordinates()
        {
            Console.WriteLine($"Координати: ( {X}  {Y}  {Z} )");
            Console.WriteLine();
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public double DistanceToDot(Dot dot)
        {
            double xOffset = X - dot.X;
            double yOffset = Y - dot.Y;
            double zOffset = Z - dot.Z;
            return Math.Sqrt(xOffset * xOffset + yOffset * yOffset + zOffset * zOffset);
        }

        public void ShowSphericalCoordinates()
        {
            double radius = DistanceToOrigin();
            double theta = radius == 0 ? 0 : Math.Acos(Z / radius);
            double phi = Math.Atan2(Y, X);

            Console.WriteLine($"Сферичні координати:");
            Console.WriteLine();

            Console.WriteLine($"Радіус = {Math.Round(radius, 2)}");
            Console.WriteLine($"Полярний кут = {Math.Round(theta, 2)} радіан, або {Math.Round(theta * 180 / Math.PI, 2)}°");
            Console.WriteLine($"Азимутальний кут = {Math.Round(phi, 2)} радіан, або {Math.Round(phi * 180 / Math.PI, 2)}°");
            Console.WriteLine();
        }

        public void ShowSymetricalDots()
        {
            Console.WriteLine($"Координати точок, симетричних до даної:");
            Console.WriteLine();

            Console.WriteLine($"- відносно площини XY: ( {X}  {Y}  {(Z != 0 ? -Z : 0)} )");
            Console.WriteLine($"- відносно площини YZ: ( {(X != 0 ? -X : 0)}  {Y}  {Z} )");
            Console.WriteLine($"- відносно площини XZ: ( {X}  {(Y != 0 ? -Y : 0)}  {Z} )");
            Console.WriteLine();
            Console.WriteLine($"- відносно осі X: ( {X}  {(Z != 0 ? -Z : 0)}  {(Z != 0 ? -Z : 0)} )");
            Console.WriteLine($"- відносно осі Y: ( {(X != 0 ? -X : 0)}  {Y}  {(Z != 0 ? -Z : 0)} )");
            Console.WriteLine($"- відносно осі Z: ( {(X != 0 ? -X : 0)}  {(Y != 0 ? -Y : 0)}  {Z} )");
            Console.WriteLine();
        }

        public void Move(double x = 0, double y = 0, double z = 0)
        {
            if (x != 0)
                X += x;
            if (y != 0)
                Y += y;
            if (z != 0)
                Z += z;
        }

        public void MoveX(double offset)
        {
            X += offset;
        }

        public void MoveY(double offset)
        {
            Y += offset;
        }

        public void MoveZ(double offset)
        {
            Z += offset;
        }
    }
}
