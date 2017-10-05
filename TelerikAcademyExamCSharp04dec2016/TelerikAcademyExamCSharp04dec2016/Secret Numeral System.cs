using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TelerikAcademyExamCSharp04dec2016
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] octalNumbers = new string[4];
            string[] tokenInput = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < 4; i++)
            {
                string currentNumber = tokenInput[i];
                string octalNumber = string.Empty;
                while (currentNumber != string.Empty)
                {
                    if (currentNumber.Length >= 9 && currentNumber.Substring(0, 9) == "hristofor")
                    {
                        octalNumber += "3";
                        currentNumber = currentNumber.Substring(9);

                    }
                    else if (currentNumber.Length >= 5 && currentNumber.Substring(0, 5) == "tosho")
                    {
                        octalNumber += "1";
                        currentNumber = currentNumber.Substring(5);
                    }
                    else if (currentNumber.Length >= 5 && currentNumber.Substring(0, 5) == "pesho")
                    {
                        octalNumber += "2";
                        currentNumber = currentNumber.Substring(5);
                    }
                    else if (currentNumber.Length >= 6 && currentNumber.Substring(0, 6) == "hristo")
                    {
                        octalNumber += "0";
                        currentNumber = currentNumber.Substring(6);

                    }
                    else if (currentNumber.Length >= 8 && currentNumber.Substring(0, 8) == "vladimir")
                    {
                        octalNumber += "7";
                        currentNumber = currentNumber.Substring(8);

                    }
                    else if (currentNumber.Length >= 9 && currentNumber.Substring(0, 9) == "haralampi")
                    {
                        octalNumber += "5";
                        currentNumber = currentNumber.Substring(9);
                    }
                    else if (currentNumber.Length >= 4 && currentNumber.Substring(0, 4) == "zoro")
                    {
                        octalNumber += "6";
                        currentNumber = currentNumber.Substring(4);
                    }
                    else if (currentNumber.Length >= 4 && currentNumber.Substring(0, 4) == "vlad")
                    {
                        octalNumber += "4";
                        currentNumber = currentNumber.Substring(4);

                    }
                }
                octalNumbers[i] = octalNumber;
            }
            BigInteger[] decNumbers = new BigInteger[4];
            for (int i = 0; i < 4; i++)
            {
                string octalNumber = octalNumbers[i];
                BigInteger result = 0;
                for (int j = 0; j < octalNumber.Length; j++)
                {
                    double num0 = double.Parse(octalNumber[j].ToString());
                    double power = (double)octalNumber.Length-1-j;
                    double num1 = Math.Pow(8, power);
                    result += (BigInteger) num0 * (BigInteger) num1;
                }
                decNumbers[i] = result;
            }
            BigInteger totalResult = 1;
            foreach (var number in decNumbers)
            {
                totalResult *= (BigInteger)number;
            }
            Console.WriteLine(totalResult);

        }
    }
}
