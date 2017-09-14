using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int inputsCounter = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputsCounter; i++)
			{
                names.Add(Console.ReadLine());
			}
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
