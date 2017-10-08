using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tres4
{
    static void Main()
    {
        string[] tresNumbers = new string[9]
        {
            "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON"
        };
        string result = string.Empty;

        ulong numberInput = ulong.Parse(Console.ReadLine());
        if (numberInput==0)
        {
            result = "LON+";
        }
        while (numberInput>0)
        {
            result = tresNumbers[numberInput%9] + result;
            numberInput /= 9;
        }
        Console.WriteLine(result);
    }
}

