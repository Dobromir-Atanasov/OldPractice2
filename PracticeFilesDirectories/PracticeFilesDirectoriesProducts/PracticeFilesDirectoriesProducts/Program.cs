using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeFilesDirectoriesProducts
{
    public class PriceQuantity
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
    class Program
    {
        public static Dictionary<string, Dictionary<string, PriceQuantity>> stockedProducts = new Dictionary<string, Dictionary<string, PriceQuantity>>();
        static void Main(string[] args)
        {
            LoadStocksFromDatabase();

            string[] tokenInput = Console.ReadLine().Split(' ').ToArray();

            while (tokenInput[0] != "exit")
            {
                switch (tokenInput[0])
                {
                    case "analyze":
                        Analyze();
                        break;
                    case "stock":
                        StockProductsToDatabase();
                        break;
                    case "sales":
                        Sales();
                        break;
                    default:
                        StoreProduc(tokenInput);
                        break;
                }
                tokenInput = Console.ReadLine().Split(' ').ToArray();
            }
        }
        static void Sales()
        {
            Dictionary<string, decimal> typeOfProductsWithTurnover = new Dictionary<string, decimal>();

            foreach (var type in stockedProducts)
            {
                string typeOfProducts = type.Key;
                decimal sum = 0;
                foreach (var product in type.Value)
                {
                    sum += product.Value.Price * (decimal)product.Value.Quantity;
                }
                typeOfProductsWithTurnover.Add(typeOfProducts, sum);
            }
            foreach (var type in typeOfProductsWithTurnover.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine("{0}: ${1:f2}", type.Key, type.Value);
            }
        }
        static void Analyze()
        {
            Dictionary<string, Dictionary<string, PriceQuantity>> stock = new Dictionary<string, Dictionary<string, PriceQuantity>>();

            string[] tokens = null;
            if (File.Exists("database.txt"))
            {
                tokens = File.ReadAllLines("database.txt");
                if (tokens==null)
                {
                    Console.WriteLine("No products stocked");
                }
                else
                {
                    foreach (var token in tokens)
                    {
                        string[] product = token.Split(' ').ToArray();
                        string type = product[0];
                        string name = product[1];
                        decimal price = decimal.Parse(product[2]);
                        int quantity = int.Parse(product[3]);

                        if (!stock.ContainsKey(type))
                        {
                            stock.Add(type, new Dictionary<string, PriceQuantity>());
                            stock[type].Add(name, new PriceQuantity());
                            stock[type][name].Price = price;
                            stock[type][name].Quantity = quantity;
                        }
                        else if (!stock[type].ContainsKey(name))
                        {
                            stock[type].Add(name, new PriceQuantity());
                            stock[type][name].Price = price;
                            stock[type][name].Quantity = quantity;
                        }
                        else
                        {
                            stock[type][name].Price = price;
                            stock[type][name].Quantity = quantity;
                        }
                    }
                    foreach (var type in stock.OrderBy(x=>x.Key))
                    {
                        foreach (var product in type.Value)
                        {
                            Console.WriteLine("{0}, Product: {1}", type.Key, product.Key);
                            Console.WriteLine("Price: ${0:f2}, Amount Left: {1}", product.Value.Price, product.Value.Quantity);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No products stocked");
            }
        }
        static void StockProductsToDatabase()
        {
            File.Delete("database.txt");
            // File.Create("database.txt");
            foreach (var groupType in stockedProducts)
            {
                string group = groupType.Key;
                foreach (var product in groupType.Value)
                {
                    string name = product.Key;
                    decimal price = product.Value.Price;
                    int quantity = product.Value.Quantity;
                    File.AppendAllText("database.txt", group + " " + name + " " + price + " " + quantity + Environment.NewLine);
                }
            }
        }
        static void LoadStocksFromDatabase()
        {
            string[] tokens = null;
            if (File.Exists("database.txt"))
            {
                tokens = File.ReadAllLines("database.txt").ToArray();
                foreach (var token in tokens)
                {
                    string[] product = token.Split(' ').ToArray();
                    string temp = product[0]; //switching type <> name to the corect positions
                    product[0] = product[1];
                    product[1] = temp;
                    StoreProduc(product);
                }
            }
        }
        static void StoreProduc(string[] tokenInput)
        {
            string type = tokenInput[1];
            string name = tokenInput[0];
            decimal price = decimal.Parse(tokenInput[2]);
            int quantity = int.Parse(tokenInput[3]);
            if (!stockedProducts.ContainsKey(type))
            {
                stockedProducts.Add(type, new Dictionary<string, PriceQuantity>());
                stockedProducts[type].Add(name, new PriceQuantity());
                stockedProducts[type][name].Price = price;
                stockedProducts[type][name].Quantity = quantity;
            }
            else if (!stockedProducts[type].ContainsKey(name))
            {
                stockedProducts[type].Add(name, new PriceQuantity());
                stockedProducts[type][name].Price = price;
                stockedProducts[type][name].Quantity = quantity;
            }
            else
            {
                stockedProducts[type][name].Price = price;
                stockedProducts[type][name].Quantity = quantity;
            }
        }
    }
}
