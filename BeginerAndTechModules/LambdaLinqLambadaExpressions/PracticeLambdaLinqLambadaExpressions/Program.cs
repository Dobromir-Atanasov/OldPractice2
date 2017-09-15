using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLambdaLinqLambadaExpressions
{
    class Program
    {
        static Dictionary<string, decimal> productsAndPrices = new Dictionary<string, decimal>();
        static Dictionary<string, Dictionary<string, decimal>> purchases = new Dictionary<string, Dictionary<string, decimal>>();
        static void Main(string[] args)
        {
            InputProductsAndPrices(); //while "Shop is open"
            ShoppingTime();
            Print(GetWinner());
        }
        static string GetWinner()
        {
            string winnerName = null;
            decimal maxSpent = 0;
            foreach (var user in purchases)
            {
                decimal totalSpent = TotalSpent(user.Key);
                if (totalSpent>maxSpent)
                {
                    winnerName = user.Key;
                    maxSpent = totalSpent;
                }
            }
            return winnerName;
        }
        static decimal TotalSpent(string userName)
        {
            return purchases[userName].Sum(x => x.Value);
        }
        static void Print(string winner)
        {
            //Do print
            Console.WriteLine("Biggest spender: {0}", winner);
            Console.WriteLine("^Products bought:");
            foreach (var product in purchases[winner])
            {
                Console.WriteLine("^^^{0}: {1}", product.Key, productsAndPrices[product.Key]);
            }
            Console.WriteLine("Total: {0}", TotalSpent(winner));
        }
        static void ShoppingTime()
        {
            string[] tokensInput = Console.ReadLine()
                .Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (tokensInput[0]!="Print")
            {
                if (tokensInput[0]=="Discount")
                {
                    DoDiscount();
                    tokensInput = Console.ReadLine()
                        .Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                }
                else
                {
                    string userName = tokensInput[0];
                    List<string> itemsBought = tokensInput[1]
                        .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    DoShopping(userName, itemsBought);
                    tokensInput = Console.ReadLine()
                        .Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                }
            }
        }
        static void DoDiscount()
        {
            Dictionary<string, decimal> discountedProducts = productsAndPrices.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, x => x.Value - x.Value / 10);
            foreach (var product in discountedProducts.OrderBy(x=>x.Value))
            {
                productsAndPrices[product.Key] = Math.Round(product.Value, 2);
            }
        }
        static void DoShopping(string userName, List<string> itemsBought)
        {
            foreach (var itemToPut in itemsBought)
            {
                if (productsAndPrices.ContainsKey(itemToPut))
                {
                    if (!purchases.ContainsKey(userName))
                    {
                        purchases[userName] = new Dictionary<string, decimal>();
                        purchases[userName].Add(itemToPut, productsAndPrices[itemToPut]);
                    }
                    else if (!purchases[userName].ContainsKey(itemToPut))
                    {
                        purchases[userName].Add(itemToPut, productsAndPrices[itemToPut]);
                    }
                    else
                    {
                        purchases[userName][itemToPut] += productsAndPrices[itemToPut];
                    }
                }
            }
        }
        static void InputProductsAndPrices()
        {
            string[] tokensInput = Console.ReadLine()
                .Split(' ')
                .ToArray();
            while (tokensInput[0]!="Shop")
            {
                string productName = tokensInput[0];
                decimal productPrice = decimal.Parse(tokensInput[1]);
                if (!productsAndPrices.ContainsKey(productName))
                {
                    productsAndPrices.Add(productName, productPrice);
                }
                else
                {
                    productsAndPrices[productName] = productPrice;
                }

                tokensInput = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
            }
        }
    }
}
