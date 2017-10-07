using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TelerikAcademyExam7Dec2016Morning
{
    class Program
    {
        static void Main(string[] args)
        {
            //TheHint();
            var specificNumbers = new string[]
            {
                "standardml 9",
                "ocaml 0",
                "haskell 1",
                "scala 2",
                "f# 3",
                "rust 5",
                "clojure 7",
                "erlang 8",
                "racket A",
                "mercury C",
                "commonlisp D",
                "scheme E",
                "curry F",
                "lisp 4",
                "elm B",
                "ml 6"

            };
            //List<string> orderedNumbers = new List<string>();
            //foreach (var number in specificNumbers.OrderBy(x=>x.Length))
            //{
            //    orderedNumbers.Add(number); //Console.WriteLine(number);
            //}
            string[] tokenInput = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            BigInteger result = 1;
            foreach (var input in tokenInput)
            {
                string hexNumber = input;
                foreach (var orderedNumber in specificNumbers)
                {
                    string[] token = orderedNumber.Split().ToArray();
                    string wordToReplace = token[0];
                    string wordNumber = token[1];
                    hexNumber = hexNumber.Replace(wordToReplace, wordNumber);
                }
                result = result * HexStringToInt(hexNumber);
            }
            Console.WriteLine(result);
        }
        private static BigInteger HexStringToInt(String str)
        {
            BigInteger value = 0;
            for (int i = 0; i < str.Length; i++)
            {
                value += HexCharToInt(str[i]) << ((str.Length - 1 - i) * 4);
            }
            return value;
        }
        private static int HexCharToInt(char ch)
        {
            if (ch < 48 || (ch > 57 && ch < 65) || ch > 70)
                throw new Exception("HexCharToInt: input out of range for Hex value");
            return (ch < 58) ? ch - 48 : ch - 55;
        }

        static void TheHint()
        {
            var hint = new string[]
        {
                        "200", "303", "315", "52", "301", "241", "302", "321", "52", "244", "253", "251",
                        "253", "312", "311", "52", "244", "303", "245", "311", "52", "312", "252", "253",
                        "311", "52", "302", "313", "301", "245", "310", "241", "300", "52", "311", "321",
                        "311", "312", "245", "301", "52", "252", "241", "314", "245", "143", "52", "201",
                        "311", "52", "312", "252", "245", "310", "245", "52", "241", "302", "52", "241",
                        "304", "304", "310", "303", "304", "310", "253", "241", "312", "245", "52", "242",
                        "313", "253", "300", "312", "113", "253", "302", "52", "250", "313", "302", "243",
                        "312", "253", "303", "302", "241", "300", "253", "312", "321", "143", "21", "14",
                        "215", "312", "310", "253", "302", "251", "114", "214", "245", "304", "300", "241",
                        "243", "245", "52", "243", "241", "302", "52", "311", "253","301", "304", "300",
                        "253", "250", "321", "52", "312", "252", "253", "302", "251", "311", "52", "241",
                        "52", "300", "303", "312", "112", "52", "254", "313", "311", "312", "52", "242",
                        "245", "52", "243", "241", "310", "245", "250", "313", "300", "52", "253", "302",
                        "52", "315", "252", "241", "312", "52", "303", "310","244", "245", "310", "52",
                        "321", "303", "313", "52", "310", "245", "304", "300", "241", "243", "245", "21",
                        "14", "220", "252", "253", "302", "255", "52", "241", "242", "303", "313", "312",
                        "52", "312", "252", "245", "52", "244", "241", "312", "241", "52", "312", "321",
                        "304", "245", "311", "52", "303", "250", "52", "312", "252", "245", "52", "312",
                        "252", "310", "245", "245", "52", "302", "313", "301", "242", "245", "310", "311",
                        "52", "241", "302", "244", "52", "312", "252", "245", "52", "310", "245", "311",
                        "313", "300", "312", "52", "113", "52", "252", "303", "315", "52", "301", "313",
                        "243", "252", "52", "253", "311", "52", "122", "234", "130", "120", "52", "110",
                        "52", "122", "234", "130", "120", "52", "110", "52", "122", "234", "130", "120", "143"
        };
            foreach (var number in hint)
            {
                Console.Write((char)ConvertFromBase6(number));
            }
        }
        static int ConvertFromBase6(string number)
        {
            return number.Select(digit => (int)digit - 48).Aggregate(0, (x, y) => x * 6 + y);
        }

    }
}
