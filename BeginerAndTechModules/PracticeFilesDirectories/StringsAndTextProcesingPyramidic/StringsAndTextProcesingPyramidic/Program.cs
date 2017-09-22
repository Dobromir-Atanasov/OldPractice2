using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndTextProcesingPyramidic
{
    class Program
    {
        static List<string> inputLines = new List<string>();
        static Dictionary<char, int> deepness = new Dictionary<char, int>();
        static void Main(string[] args)
        {
            //Read input data
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                inputLines.Add(Console.ReadLine());
            }
            //get the deepness of char sequences
            for (int i = 0; i < inputLines.Count; i++)
            {
                for (int j = 0; j < inputLines[i].Length; j++)
                {
                    GetMaxDeepOfChar(inputLines[i][j], i);
                }
            }
            //Get max Result
            char ch = GetMaxDeepness();
            //Print Output
            for (int i = 1; i <= deepness[ch]; i+=2)
            {
                Console.WriteLine(new string(ch, i));
            }
            //TestOutput
            //foreach (var charInfo in deepness)
            //{
            //    Console.WriteLine("{0} -> {1}", charInfo.Key, charInfo.Value);
            //}
        }
        static char GetMaxDeepness()
        {
            char result = ' ';
            int maxValue = 0;
            foreach (var item in deepness)
            {
                if (item.Value>maxValue)
                {
                    result = item.Key;
                    maxValue = item.Value;
                }
            }
            return result;
        }
        static void GetMaxDeepOfChar(char ch, int numberOfLineToStartChecking)
        {
            int counterOfDeepnes = 1;
            for (int i = numberOfLineToStartChecking; i < inputLines.Count; i++)
            {
                if (inputLines[i].Contains(new String(ch, counterOfDeepnes)))
                {
                    if (!deepness.ContainsKey(ch))
                    {
                        deepness.Add(ch, counterOfDeepnes);
                    }
                    else if (deepness[ch] < counterOfDeepnes)
                    {
                        deepness[ch] = counterOfDeepnes;
                    }
                    counterOfDeepnes += 2;
                }
                else
                {
                    break;
                }
        
            }
        }
    }
}
