using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CovertFromOneBaseToAnother
{
    class Program
    {
        static void Main()
        {
            int fromBase = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            int toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(BaseXToBaseY(number, fromBase, toBase));
        }

        // GetChar(15) -> 'F'
        static char GetChar(BigInteger i)
        {
            if (i >= 10) return (char)('A' + i - 10);
            else return (char)('0' + i);
        }

        // GetNumber("587", 2) -> 7
        static int GetNumber(string s, BigInteger i)
        {
            if (s[(int)i] >= 'A') return s[(int)i] - 'A' + 10;
            else return s[(int)i] - '0';
        }

        // Exercise 1
        static string Base10ToBaseX(BigInteger d, BigInteger x)
        {
            string h = String.Empty;

            for (; d != 0; d /= x) h = GetChar(d % x) + h;

            return h;
        }

        // Exercise 2
        static BigInteger BaseXToBase10(string h, BigInteger x)
        {
            BigInteger d = 0;

            for (BigInteger i = h.Length - 1, p = 1; i >= 0; i--, p *= x)
                d += GetNumber(h, i) * p;

            return d;
        }

        static string BaseXToBaseY(string n, BigInteger x, BigInteger y)
        {
            return Base10ToBaseX(BaseXToBase10(n, x), y); // Use base 10 as proxy
        }
    }
}
