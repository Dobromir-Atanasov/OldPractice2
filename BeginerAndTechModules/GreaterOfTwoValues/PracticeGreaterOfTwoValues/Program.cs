using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeGreaterOfTwoValues
{
    class Program
    {
        public static bool aGreater = false;
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                aGreater = GetMax(a, b);
                if (aGreater)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }

            }
            else
            {
                var a = Console.ReadLine();
                var b = Console.ReadLine();
                aGreater = GetMax(a, b);
                if (aGreater)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }

            }
        }

        public static bool GetMax(int a, int b)
        {
            if (a >= b)
            {
                aGreater = true;
            }
            return aGreater;
        }
        public static bool GetMax(char a, char b)
        {
            if (a >= b)
            {
                aGreater = true;
            }
            return aGreater;
        }
        public static bool GetMax(string a, string b)
        {
            if (a.CompareTo(b)>=0)
            {
                aGreater = true;
            }
            return aGreater;
        }
    }
}
