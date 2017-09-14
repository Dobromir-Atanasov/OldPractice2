using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLambdaLinqStringMostValuedCustomer
{
    class Program
    {
        static Dictionary<string, decimal> products = new Dictionary<string, decimal>();
        static Dictionary<string, Dictionary<string, decimal>> spends = new Dictionary<string, Dictionary<string, decimal>>();
        static void Main(string[] args)
        {
            WhileShopIsClosedRecieveProductsAndPrices();
            WhenShopIsOpenRecievePurchases();
            GetTheWinner();
            //Print
            Console.ReadLine();




        }
        public static Dictionary<string, decimal> GetTheWinner()
        {
            Dictionary<string, decimal> customersSpends = new Dictionary<string, decimal>();
            foreach (var customer in spends)
            {
                decimal totalSpend = customer.Value.Select(x => x.Value).Sum();
                customersSpends.Add(customer.Key, totalSpend);
            }
        }
        public static decimal TotalSpend()
        {

        }
        public static void WhenShopIsOpenRecievePurchases()
        {
            string[] inputTokens = Console.ReadLine()
                            .Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
            while (inputTokens[0] != "Print")
            {
                if (inputTokens[0] == "Discount")
                {
                    DoDiscount();
                }
                else
                {
                    string name = inputTokens[0];
                    string[] productsNameBought = inputTokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    foreach (var product in productsNameBought)
                    {
                        if (!spends.ContainsKey(name))
                        {
                            spends[name] = new Dictionary<string,decimal>();
                            spends[name].Add(product, products[product]);
                        }
                        else if (!spends[name].ContainsKey(product))
                        {
                            spends[name].Add(product, products[product]);
                        }
                        else
                        {
                            spends[name][product] += products[product];
                        }
                    }
                }
                inputTokens = Console.ReadLine()
                            .Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
            }
        }
        public static void DoDiscount()
        {
            Dictionary<string, decimal> discountedProducts = new Dictionary<string, decimal>();
            discountedProducts = products.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<string, decimal> discountedProduct in discountedProducts)
            {
                products[discountedProduct.Key] -= discountedProduct.Value / 10; //cut off 10%
            }
        }
        public static void WhileShopIsClosedRecieveProductsAndPrices()
        {
            string[] inputTokens = Console.ReadLine()
                                .Split(' ')
                                .ToArray();

            while (inputTokens[0] != "Shop")
            {
                string product = inputTokens[0];
                decimal price = decimal.Parse(inputTokens[1]);

                products[product] = price;

                inputTokens = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
