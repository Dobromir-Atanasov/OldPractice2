using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int[,] data = new int[2, counter];
            string token = string.Empty;
            for (int i = 0; i < counter; i++)
            {
                token = Console.ReadLine();
                data[0, i] = int.Parse(token[0].ToString());
                data[1, i] = int.Parse(token[1].ToString());
            }
            List<int> mix = new List<int>();
            List<int> substract = new List<int>();
            for (int i = 0; i < counter-1; i++)
            {
                mix.Add(data[1, i] * data[0, i + 1]);
                substract.Add(Math.Abs((data[0,i]*10+data[1,i]) - (data[0,i+1]*10+data[1,i+1])));
            }
            Console.WriteLine(string.Join(" ", mix));
            Console.WriteLine(string.Join(" ", substract));
        }
    }
}
