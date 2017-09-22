using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikPaperCutter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] availableSheets = new string[11] { 
                "A10", "A9", "A8", "A7", "A6", "A5", "A4", "A3", "A2", "A1", "A0" };
            int n = int.Parse(Console.ReadLine());
            while (n!=0)
            {
                for (int i = 10; i >=0; i--)
                {
                    if (Math.Pow(2, i)<=n&&availableSheets[i]!="taken")
                    {
                        n = n-(int)Math.Pow(2, i);
                        availableSheets[i] = "taken";
                    }
                }
            }
            foreach (var sheet in availableSheets)
            {
                if (sheet!="taken")
                {
                    Console.WriteLine(sheet);
                }
            }
        }
    }
}
