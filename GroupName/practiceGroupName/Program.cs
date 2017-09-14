using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceGroupName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input Data
            char name0 = char.Parse(Console.ReadLine());
            char name1 = char.Parse(Console.ReadLine());
            char name2 = char.Parse(Console.ReadLine());
            char name3 = char.Parse(Console.ReadLine());
            int name4 = int.Parse(Console.ReadLine());
            int counter = 0;

            for (char c1 = 'A'; c1 <= name0; c1++)
            {
                for (char c2 = 'a'; c2 <= name1; c2++)
                {
                    for (char c3 = 'a'; c3 <= name2; c3++)
                    {
                        for (char c4 = 'a'; c4 <= name3; c4++)
                        {
                            for (int i = 0; i <= name4; i++)
                            {
                                counter++;
                            }
                        }

                    }
                }
                
            }

            Console.WriteLine(counter-1);




            //Cycles

            //Result Output

        }
    }
}
