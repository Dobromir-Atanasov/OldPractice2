using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputString = Console.ReadLine().Split('|').ToList();

            inputString.Reverse();

            string result = "";

            foreach (var item in inputString)
            {
                List<string> temp = item.Split(' ').ToList();
                foreach (var item1 in temp)
                {
                    if (item1!=" "&&item1!="")
                    {
                        result = result + item1 + " ";
                    }
                }
            }
            Console.Write("{0} ", result);
        }
    }
}
