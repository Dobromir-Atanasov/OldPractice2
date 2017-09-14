using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikCryptoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine((int)'0');
            string firstString = "bac"; // Console.ReadLine();
            string oper = "+"; // Console.ReadLine();
            string secondString = "10"; // Console.ReadLine();
            double firstNumber = DecodeFirstLine(firstString);
            double secondNumber = DecodeSecondLine(secondString);
            double thirdNumber = 0;
            if (oper == "+")
            {
                thirdNumber = firstNumber + secondNumber;
            }
            else
            {
                thirdNumber = firstNumber - secondNumber;
            }
            Console.WriteLine(DecodeResult(thirdNumber));
        }
        static string DecodeResult(double token)
        {
            int number = (int)token;
            string result = string.Empty;
            int counter = 0;
            while (number>0)
            {
                result = (number % 9).ToString() + result;
                number = number - (number / (int)Math.Pow(9,counter));
                counter++;
            }

            return result;
        }
        static double DecodeSecondLine(string token)
        {
            double result = 0;
            char[] chArr = token.Reverse().ToArray();
            for (int i = 0; i < chArr.Length; i++)
            {
                result += (chArr[i] - 48) * Math.Pow(7, i);
                Console.WriteLine(result);
            }
            return result;
        }
        static double DecodeFirstLine(string token)
        {
            double result = 0;
            char[] chArr = token.Reverse().ToArray();
            for (int i = 0; i < chArr.Length; i++)
            {
                //Console.WriteLine(chArr[i] - 97);
                //Console.WriteLine(Math.Pow(26, i));
                result += (chArr[i] - 97) * Math.Pow(26, i);
            }
            return result;
        }
    }
}
