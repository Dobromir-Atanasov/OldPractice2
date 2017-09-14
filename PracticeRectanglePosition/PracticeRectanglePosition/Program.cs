using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRectanglePosition
{
    class Program
    {
        class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int Bottom { get; set; }
            public int Right { get; set; }
        }
        static void Main(string[] args)
        {
            Rectangle r1 = GetDataFromConsole();
            Rectangle r2 = GetDataFromConsole();

            bool result = IsInside(r1, r2);

            if (result)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
        static Rectangle GetDataFromConsole()
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            return new Rectangle() { Left = coordinates[0], Top = coordinates[1], Width = coordinates[2], Height = coordinates[3],
            Bottom = coordinates[1] + coordinates[3], Right = coordinates[0] + coordinates[2] };
        }

        static bool IsInside(Rectangle r1, Rectangle r2)
        {
            bool result = false;
            if (r1.Left >= r2.Left && r1.Right <= r2.Right && r1.Top <= r2.Top && r1.Bottom <= r2.Bottom)
            {
                result = true;
            }
            return result;
        }
    }
}
