using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            int[] setsLenght = Console.ReadLine() //Get the 2 sets Lenghts
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();
            HashSet<int> setN = new HashSet<int>();
            HashSet<int> setM = new HashSet<int>();
            GetElements(setN, setsLenght[0]);
            GetElements(setM, setsLenght[1]);
            setN.IntersectWith(setM);
            PrintSet(setN);
            //PrintSet(setM);

        }
        static void PrintSet(HashSet<int> setToPrint)
        {
            Console.WriteLine(string.Join(" ", setToPrint));
        }
        static void GetElements(HashSet<int> set, int numberOfElements)
        {
            for (int i = 0; i < numberOfElements; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }
        }
    }
}
