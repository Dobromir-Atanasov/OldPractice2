using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine(Convert.ToUInt64(Console.ReadLine(),2)); //In love with OneLineSollution
    }
}

// Way faster
//class BinaryToDecimal
//{
//    static void Main()
//    {
//        string binaryNumber = Console.ReadLine();
//        ulong result = Convert.ToUInt64(binaryNumber, 2);
//        Console.WriteLine(result);
//    }
//}

//Beter but still can be improved
//class BinaryToDecimal
//{
//    static void Main()
//    {
//        char[] binaryNumber = Console.ReadLine().ToArray();
//        ulong result = 0;
//        for (int i = 0; i < binaryNumber.Length; i++)
//        {
//            result = result * 2 + uint.Parse(binaryNumber[i].ToString());
//        }
//        Console.WriteLine(result);
//    }
//}

//Following solution works but it's not optimal
//class BinaryToDecimal
//{
//    static void Main()
//    {
//        char[] binaryNumber = Console.ReadLine().ToArray();
//        ulong result = 0;
//        for (int i = 0; i < binaryNumber.Length; i++)
//        {
//            result += ulong.Parse(binaryNumber[i].ToString()) * (ulong)Math.Pow(2, binaryNumber.Length - 1 - i);
//        }
//        Console.WriteLine(result);
//    }
//}

