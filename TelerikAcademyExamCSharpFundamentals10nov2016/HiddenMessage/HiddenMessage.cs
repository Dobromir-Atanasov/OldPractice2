using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenMessage
{
    class HiddenMessage
    {
        static void Main(string[] args)
        {
            string tokenInputOne = Console.ReadLine();
            string tokenInputTwo = string.Empty;
            string tokenInputThree = string.Empty;
            StringBuilder result = new StringBuilder();
            while (tokenInputOne!="end")
            {
                tokenInputTwo = Console.ReadLine();
                tokenInputThree = Console.ReadLine();
                int index = int.Parse(tokenInputOne);
                int step = int.Parse(tokenInputTwo);
                string text = tokenInputThree;

                if (index<0)
                {
                    index = text.Length + index;
                }
                if (step>=0)
                {
                    //go forward   
                    while (index<=text.Length-1)
                    {
                        result.Append(text[index]);
                        index += step;
                    }
                }
                else
                {
                    //go backward
                    while (index>=0)
                    {
                        result.Append(text[index]);
                        index += step;
                    }
                }
                tokenInputOne = Console.ReadLine();
            }
            Console.WriteLine(result);
        }
    }
}
