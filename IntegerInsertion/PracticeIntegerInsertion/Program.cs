using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeIntegerInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitSimbol = new char[] { ' ' };
            List<int> inputData = Console.ReadLine()
                .Split(splitSimbol, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool exitTime = true;
            while (exitTime)
            {
                string inputString = Console.ReadLine();
                if (inputString!="end")
                {
                    int number = int.Parse(inputString);
                    int firstCharOfTheString = (int)(inputString.ElementAt(0))-48;
                    inputData.Insert(firstCharOfTheString, number);
                }
                else
                {
                    exitTime = false;
                }
            }
            Console.WriteLine(string.Join(" ", inputData));
        }
    }
}
