using System;

namespace PracticeIfCicle
{
    class Program
    {
        public static int n = 10;
        public static bool _break = false;

        static void Main(string[] args)
        {
            int i = 0;
            bool result = Cycle(i);
            Console.WriteLine(result);
        }

        public static bool Cycle(int _i)
        {
            if (_i>=n)
            {
                _break = true;
            }
            else
            {
                Console.WriteLine(_i);
                _i++;
                Cycle(_i);
            }
            return _break;
        }
    }
}
