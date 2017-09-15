using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikExamAlfaNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            string command = string.Empty;
            string digit = string.Empty;


            string input = Console.ReadLine();

            while (input!="end")
            {
                command = string.Empty;
                digit = string.Empty;

                string[] splited = input.Split(' ');
                if (splited.Length>1)
                {
                    command = splited[0];
                    digit = splited[1];
                }
                else
                {
                    command = splited[0];
                }

                switch (command)
                {
                    case "set":
                        result = digit;
                        break;
                    case "front-add":
                        result = result.Insert(0, digit);
                        break;
                    case "front-remove":
                        if (result.Length > 0)
                        {
                            result = result.Remove(0, 1);
                        }
                        break;
                    case "back-add":
                        result = result.Insert(result.Length, digit);
                        break;
                    case "back-remove":
                        if (result.Length > 0)
                        {
                            result = result.Remove(result.Length - 1, 1);
                        }
                        break;
                    case "reverse":
                        result = Reverse(result);
                        break;
                    case "print":
                        Console.WriteLine(result);
                        break;
                    default:
                        break;
                }


                input = Console.ReadLine();
            }
        }
       public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
