using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixGrid
{
    // 40 /100 update
    // 30/100 Maybe I should use RegEx???
    class PhoenixGrid
    {
        static void Main()
        {
            bool isInputValid = true;
            string token = Console.ReadLine();
            while (token != "ReadMe")
            {
                string[] tokenSplitted = token.Split('.');
                if (token.Length < 3)
                {
                    isInputValid = false;
                }
                else
                {
                    if (tokenSplitted.Length < 1 && isInputValid)
                    {
                        isInputValid = false;
                    }
                    foreach (var phrase in tokenSplitted)
                    {
                        if (phrase.Length != 3 && isInputValid)
                        {
                            isInputValid = false;
                            break;
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            if (phrase[i] == ' ' || phrase[i] == '_' && isInputValid)
                            {
                                isInputValid = false;
                                break;
                            }
                        }
                    }
                    for (int i = 0; i < tokenSplitted.Length / 2; i++)
                    {
                        if (tokenSplitted[i] != Reverse(tokenSplitted[tokenSplitted.Length - 1 - i]) && isInputValid)
                        {
                            isInputValid = false;
                            break;
                        }
                    }
                    if (tokenSplitted.Length % 2 != 0 && isInputValid)
                    {
                        string phrase = tokenSplitted[tokenSplitted.Length / 2];
                        if (phrase[0] != phrase[2])
                        {
                            isInputValid = false;
                        }
                    }
                }


                PrintResult(isInputValid);
                isInputValid = true;
                token = Console.ReadLine();
            }
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void PrintResult(bool isInputValid)
        {
            if (isInputValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
