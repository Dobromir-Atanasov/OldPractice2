using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TelerikExamPractice4Feb2013Morning
{
    class KaspichanNumbers
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            string output = string.Empty;
            var digits256 = new List<string>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                digits256.Add(i.ToString());
            }
            for (char i = 'a'; i <= 'i'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    digits256.Add(i.ToString() + j.ToString());
                }
            }
            //Console.WriteLine(digits256.Count);
            //Console.WriteLine(string.Join(" ", digits256));
            if (number == 0)
            {
                output = "A";
            }
            while (number>0)
            {
                output = digits256[(int)(number % 256)]+output;
                number /= 256;
                //if (number==0) // Moved out of cycle to improve productivity
                //{
                //    break;
                //}
            }
            Console.WriteLine(output);
        }
    }
}
