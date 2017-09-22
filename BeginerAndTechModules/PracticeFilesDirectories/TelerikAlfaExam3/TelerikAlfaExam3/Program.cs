using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikAlfaExam3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            int[] carsSpeed = new int[numberOfCars];
            for (int i = 0; i < numberOfCars; i++)
            {
                carsSpeed[i] = int.Parse(Console.ReadLine());
            }
            //carsSpeed = carsSpeed.Reverse().ToArray(); //reverse for easy handling
            int[] stacks = new int[numberOfCars];
            stacks[0] = 1;
            int[] speedsCalculation = new int[numberOfCars];
            speedsCalculation[0] = carsSpeed[0];
            for (int i = 0; i < numberOfCars-1; i++)
            {
                if (speedsCalculation[i] < carsSpeed[i + 1])
                {
                    speedsCalculation[i+1] = speedsCalculation[i];
                    stacks[i+1] = stacks[i] + 1;
                }
                else
                {
                    stacks[i+1] = 1;
                    speedsCalculation[i+1] = carsSpeed[i+1];
                }
            }
            int longestStack = 0;
            int maxSpeedSum = 0;
            int currentSum = 0;
            for (int i = 0; i < numberOfCars; i++)
            {
                if (stacks[i]>longestStack)
                {
                    longestStack = stacks[i];
                }
                
            }
            for (int i = 0; i < numberOfCars; i++)
            {
                if (stacks[i]==longestStack)
                {
                    for (int j = i; j > i-longestStack; j--)
                    {
                        currentSum += carsSpeed[j];
                    }
                    if (currentSum>maxSpeedSum)
                    {
                        maxSpeedSum = currentSum;
                        currentSum = 0;
                    }
                    else
                    {
                        currentSum = 0;
                    }
                }
            }
            Console.WriteLine(maxSpeedSum);
        }
    }
}
