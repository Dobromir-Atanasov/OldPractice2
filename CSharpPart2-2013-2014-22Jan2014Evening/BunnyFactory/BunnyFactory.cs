using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class BunnyFactory
{
    static void Main()
    {
        List<BigInteger> cages = new List<BigInteger>();
        string tokenInput = Console.ReadLine();
        while (tokenInput != "END")
        {
            cages.Add(BigInteger.Parse(tokenInput));
            tokenInput = Console.ReadLine();
        }
        //PrintCages(cages);
        bool keepWorking = true;
        int cycle = 1;
        string result = string.Empty;
        BigInteger cycleSum = 0;
        BigInteger nextCycleSumCagesSum = 0;
        BigInteger nextCycleSumCagesProduction = 1;
        while (keepWorking)
        {
            //if cages<cycle stop
            if (cycle > cages.Count)
            {
                keepWorking = false;
                break;
            }
            for (int i = 0; i < cycle; i++)
            {
                cycleSum += cages[i];
            }
            if (cycle + cycleSum > cages.Count)
            {
                keepWorking = false;
                break;
            }
            for (int i = cycle; i < cycleSum+cycle; i++)
            {
                nextCycleSumCagesSum += cages[i];
                nextCycleSumCagesProduction *= cages[i];
            }
            //Console.WriteLine(nextCycleSumCagesSum.ToString());
            result = nextCycleSumCagesSum.ToString() + nextCycleSumCagesProduction.ToString();
            for (int i = (int)cycleSum + cycle; i < cages.Count; i++)
            {
                result += cages[i];
            }
            result = result.Replace("0", "");
            result = result.Replace("1", "");
            cages.Clear();
            for (int i = 0; i < result.Length; i++)
            {
                cages.Add(result[i]-'0');
            }

            cycle++;
            result = string.Empty;
            cycleSum = 0;
            nextCycleSumCagesSum = 0;
            nextCycleSumCagesProduction = 1;
        }
        PrintCages(cages);
    }
    static void PrintCages(List<BigInteger> cages)
    {
        Console.WriteLine(string.Join(" ", cages));
    }
}

