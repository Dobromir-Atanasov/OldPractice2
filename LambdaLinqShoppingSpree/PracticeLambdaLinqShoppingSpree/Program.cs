using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLambdaLinqShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());

            Dictionary<string, decimal> shoppingList = new Dictionary<string, decimal>();

            string[] inputTokens = Console.ReadLine()
                .Split(' ')
                .ToArray();

            while (inputTokens[0] != "end")
            {
                string food = inputTokens[0];
                decimal price = decimal.Parse(inputTokens[1]);

                if (shoppingList.ContainsKey(food))
                {
                    if (shoppingList[food] > price)
                    {
                        shoppingList[food] = price;
                    }
                }
                else
                {
                    shoppingList[food] = price;
                }

                inputTokens = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
            }
            //sorting
            shoppingList = shoppingList
                .OrderBy(kvp => kvp.Key.Length)
                .OrderByDescending(kvp => kvp.Value)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            decimal sumToSpend = 0;

            foreach (var product in shoppingList)
            {
                sumToSpend += product.Value;
            }

            if (sumToSpend > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                foreach (var item in shoppingList)
                {
                    Console.WriteLine("{0} costs {1:f2}", item.Key, item.Value);
                }
            }
        }
    }
}
