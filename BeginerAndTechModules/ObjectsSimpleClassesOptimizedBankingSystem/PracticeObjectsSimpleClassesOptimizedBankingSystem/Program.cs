using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectsSimpleClassesOptimizedBankingSystem
{
    class Program
    {
        public class BankAccaunt
        {
            public string bank;
            public string accountName;
            public string accountBalance;
            public decimal balance;
        }

        static List<BankAccaunt> accounts= new List<BankAccaunt>();
        static void Main(string[] args)
        {
            GetDataFromConsole();
            PrintData();
        }
        static void PrintData()
        {
            foreach (var item in accounts.OrderByDescending(x=>x.balance).ThenBy(x=>x.bank.Length))
            {
                Console.WriteLine("{0} -> {1} ({2})", item.accountName, item.accountBalance, item.bank);
            }
        }
        static void GetDataFromConsole()
        {
            string[] tokensInput = Console.ReadLine()
                .Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (tokensInput[0]!="end")
            {
                string bankNameInput = tokensInput[0];
                string accauntNameInput = tokensInput[1];
                string accauntBalanceInput = tokensInput[2];

                accounts.Add(new BankAccaunt {
                    bank = bankNameInput,
                    accountName = accauntNameInput,
                    accountBalance = accauntBalanceInput,
                    balance = decimal.Parse(accauntBalanceInput) });

                tokensInput = Console.ReadLine()
                .Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
        }
    }
}
