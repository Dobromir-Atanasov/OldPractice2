//Write a simple program that reads from the console a sequence of usernames
//and keeps a collection with only the unique ones.
//Print the collection on the console in order of insertion:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCSharpAdvSetAndDictionariesExercises
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            HashSet<string> hSet = new HashSet<string>();
            int inputDataCounts = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputDataCounts; i++)
            {
                hSet.Add(Console.ReadLine());
            }
            foreach (var save in hSet)
            {
                Console.WriteLine(save);
            }
        }
    }
}
