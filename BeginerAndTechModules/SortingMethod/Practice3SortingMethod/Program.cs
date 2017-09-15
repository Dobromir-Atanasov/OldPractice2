using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3SortingMethod
{
    class Program
    {
        public static int GetMaxNumber(int[] ar)
        {
            int maxValue = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i]>maxValue)
                {
                    maxValue = ar[i];
                }
            }
            return maxValue;
        }
        public static void PrintArray(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Make Array
            int[] ar = new int[50];
            Random r = new Random();
            for (int i = 0; i < 50; i++)
            {
                ar[i] = r.Next(0, 100); //fills array with Random ints(1,100)
            }
            PrintArray(ar);
            Array.Sort(ar);
            PrintArray(ar);

        }
    }
}
