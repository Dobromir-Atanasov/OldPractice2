using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClossestTwoPoints
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int numberOfPointsGiven = int.Parse(Console.ReadLine());
            Point[] arrPoints = new Point[numberOfPointsGiven];
            for (int i = 0; i < numberOfPointsGiven; i++)
            {
                arrPoints[i] = PointReader(Console.ReadLine());
            }
            //Compare
            double smalestDistanceFound = CalcPointDistance(arrPoints[0], arrPoints[1]);
            Point point1 = arrPoints[0];
            Point point2 = arrPoints[1];
            for (int i = 0; i < numberOfPointsGiven; i++)
            {
                for (int j = i + 1; j < numberOfPointsGiven; j++)
                {
                    double distance = CalcPointDistance(arrPoints[i], arrPoints[j]);
                    if (distance<smalestDistanceFound)
                    {
                        point1 = arrPoints[i];
                        point2 = arrPoints[j];
                        smalestDistanceFound = distance;
                    }
                }
            }
            
            //Output
            Console.WriteLine(smalestDistanceFound);
            Console.WriteLine("({0}, {1})", point1.x, point1.y);
            Console.WriteLine("({0}, {1})", point2.x, point2.y);
        }
        static Point PointReader(string input)
        {
            int[] coordinates = input.Split(' ').Select(int.Parse).ToArray();
            return new Point() { x = coordinates[0], y = coordinates[1] };
        }

        static double CalcPointDistance(Point point1, Point point2)
        {
            int x = Math.Abs(Math.Max(point1.x, point2.x) - Math.Min(point1.x, point2.x));
            int y = Math.Abs(Math.Max(point1.y, point2.y) - Math.Min(point1.y, point2.y));
            double result = Math.Sqrt((double)(x * x + y * y));
            return result;
        }
    }
}
