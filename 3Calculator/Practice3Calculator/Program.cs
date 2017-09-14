using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num0 = double.Parse(Console.ReadLine());
            double num1 = double.Parse(Console.ReadLine());
            string caseSwitch = Console.ReadLine();


            if ((num1 == 0) && (caseSwitch == "/") ^ (caseSwitch == "%"))
            {
                Console.WriteLine("Cannot divide {0} by zero", num0);
            }
            else
            {
                double result = 0;
                string evenOdd = "odd";
                switch (caseSwitch)
                {
                    case "+": result = num0 + num1;
                    if (result % 2 == 0)
                    {
                        evenOdd = "even";
                    }
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", num0, caseSwitch, num1, result, evenOdd);
                        break;
                    case "-": result = num0 - num1;
                    if (result % 2 == 0)
                    {
                        evenOdd = "even";
                    }
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", num0, caseSwitch, num1, result, evenOdd);
                        break;
                    case "*": result = num0 * num1;
                    if (result % 2 == 0)
                    {
                        evenOdd = "even";
                    }
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", num0, caseSwitch, num1, result, evenOdd);
                        break;
                    case "/": result = num0 / num1;
                        Console.WriteLine("{0} / {1} = {2:f2}", num0, num1, result);
                        break;
                    case "%": result = num0 % num1;
                        Console.WriteLine("{0} % {1} = {2}", num0, num1, result);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
