using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSumTwoBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = new int[101];
            int[] numberOneArray = new int[100];
            string numberInputOne = Console.ReadLine();
            StringToArray(numberInputOne, numberOneArray);
            int[] numberTwoArray = new int[100];
            string numberInputTwo = Console.ReadLine();
            StringToArray(numberInputTwo, numberTwoArray);
            for (int i = 0; i < 100; i++)
            {
                if (numberOneArray[i]+numberTwoArray[i]>9)
                {
                    result[i+1]++;
                    result[i] = numberOneArray[i]+numberTwoArray[i]-10;
                }
                else
                {
                    result[i] = result[i] + numberOneArray[i] + numberTwoArray[i];
                }
            }
            PrintArray(numberOneArray);
            PrintArray(numberTwoArray);
            PrintArray(result);

        }

        public static void PrintArray(int[] _arrayToPrint)
        {
            for (int i = _arrayToPrint.Length-1; i >= 0; i--)
			{
                Console.Write(_arrayToPrint[i]);			 
			}
            Console.WriteLine();
        }
        public static void StringToArray(string stringToConvert, int[] numberOneArray)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(stringToConvert);
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                numberOneArray[i] = (int)asciiBytes[asciiBytes.Length-1-i] - 48;
            }
        }
    }
}
