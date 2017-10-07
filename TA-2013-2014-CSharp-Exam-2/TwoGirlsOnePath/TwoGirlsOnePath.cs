using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Program
{
    
    static void Main()
    {
        BigInteger[] flowers = Console.ReadLine()
            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(BigInteger.Parse)
            .ToArray();

        string stillWorking = string.Empty;
        BigInteger mollyFlowers = 0;
        BigInteger dollyFlowers = 0;
        BigInteger positionMolly = 0;
        BigInteger positionDolly = flowers.Length-1;
        while (stillWorking == string.Empty)
        {
            if (positionMolly>flowers.Length-1)
            {
                positionMolly -= flowers.Length;
            }
            if (positionDolly<0)
            {
                positionDolly += flowers.Length;
            }
            if (positionMolly==positionDolly)
            {
                if (flowers[(int)positionDolly % flowers.Length] == 0 && flowers[(int)positionMolly % flowers.Length] == 0)
                {
                    stillWorking = "Draw"; //no flowers to collect
                    break;
                }
                if (flowers[(int)positionDolly]==0)
                {
                    stillWorking = "Dolly"; //no flowers to collect
                    break;
                }
                if (flowers[(int)positionMolly]==0)
                {
                    stillWorking = "Molly";
                    break;
                }
                else
                {
                    if (flowers[(int)positionDolly]%2==0)
                    {
                        //split flowers
                        BigInteger mollyJump = flowers[(int)positionMolly % flowers.Length];
                        BigInteger dollyJump = flowers[(int)positionDolly % flowers.Length];
                        mollyFlowers += flowers[(int)positionMolly % flowers.Length] /2;
                        dollyFlowers += flowers[(int)positionDolly % flowers.Length] /2;
                        flowers[(int)positionMolly % flowers.Length] = 0;
                        flowers[(int)positionDolly % flowers.Length] = 0;
                        positionMolly += mollyJump;
                        positionDolly -= dollyJump;

                    }
                    else
                    {
                        //split flowers leave 1
                        BigInteger mollyJump = flowers[(int)positionMolly % flowers.Length];
                        BigInteger dollyJump = flowers[(int)positionDolly % flowers.Length];
                        mollyFlowers += flowers[(int)positionMolly % flowers.Length] /2;
                        dollyFlowers += flowers[(int)positionDolly % flowers.Length] /2;
                        flowers[(int)positionMolly % flowers.Length] = 1;
                        flowers[(int)positionDolly % flowers.Length] = 1;
                        positionMolly += mollyJump;
                        positionDolly -= dollyJump;

                    }
                }
            }
            else
            {
                BigInteger mollyJump = flowers[(int)(positionMolly %flowers.Length)];
                BigInteger dollyJump = flowers[(int)(positionDolly %flowers.Length)];
                mollyFlowers += flowers[(int)positionMolly % flowers.Length];
                dollyFlowers += flowers[(int)positionDolly % flowers.Length];

                if (flowers[(int)positionMolly % flowers.Length] == 0 && flowers[(int)positionDolly % flowers.Length] == 0)
                {
                    stillWorking = "Draw";
                    break; //no flowers to collect
                }
                if (flowers[(int)positionMolly]== 0)
                {
                    stillWorking = "Molly";
                    break; //no flowers to collect
                }
                if (flowers[(int)positionDolly] == 0)
                {
                    stillWorking = "Dolly";
                    break; //no flowers to collect

                }
                if (mollyJump == 0|| dollyJump == 0)
                {
                    stillWorking = "Draw";
                    break;
                }
                if (mollyJump==0)
                {
                    stillWorking = "Molly";
                    break; //no flowers to collect
                }
                if (dollyJump == 0)
                {
                    stillWorking = "Dolly";
                    break; //no flowers to collect
                }
                flowers[(int)positionMolly % flowers.Length] = 0;
                flowers[(int)positionDolly % flowers.Length] = 0;
                positionMolly += mollyJump;
                positionDolly -= dollyJump;
            }
        }
        if (stillWorking=="Draw")
        {
            Console.WriteLine("Draw");
        }
        else
        {
            if (stillWorking == "Molly")
            {
                Console.WriteLine("Dolly");
            }
            if (stillWorking == "Dolly")
            {
                Console.WriteLine("Molly");
            }

        }
        Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
    }
}

