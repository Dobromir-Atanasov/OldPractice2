using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class StrangeLandNumbers
{
    static void Main()
    {
        string[] strangleNumbers = new string[7]
        {
            "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT",
        };

        string numberInput = Console.ReadLine();

        BigInteger result = 0;
        for (int i = 0; i < strangleNumbers.Length; i++)
        {
            numberInput = numberInput.Replace(strangleNumbers[i], i.ToString());
            //Console.WriteLine(numberInput);
        }
        for (int i = 0; i < numberInput.Length; i++)
        {
            result = result * 7 + int.Parse(numberInput[i].ToString());
        }
        Console.WriteLine(result);
    }
}

