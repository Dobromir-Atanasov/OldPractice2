using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBlankReceipt
{
    class Program
    {
        public static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrindReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }

        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrindReceiptFooter();
        }
        static void Main(string[] args)
        {
            PrintReceipt();
        }
    }
}
