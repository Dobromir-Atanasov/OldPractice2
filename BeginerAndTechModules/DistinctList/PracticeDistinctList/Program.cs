using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDistinctList
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] stringSeparator = new char[] { ' ' };
            List<int> inputData = Console.ReadLine()
                .Split(stringSeparator, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int listLenght = inputData.Count;
            for (int i = 0; i < listLenght; i++)
            {
                for (int j = i+1; j < listLenght; j++)
                {
                    if (inputData[i]==inputData[j])
                    {
                        inputData.RemoveAt(j);
                        listLenght--;
                        j--;
                    }
                }
            }
            Console.Write(string.Join(" ", inputData));
        }
    }
}
