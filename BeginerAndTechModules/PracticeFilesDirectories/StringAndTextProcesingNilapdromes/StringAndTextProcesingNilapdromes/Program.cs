using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndTextProcesingNilapdromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = Console.ReadLine();
            while (token!="end")
            {
                string output = IsItNilapdrome(token);
                if (output!=string.Empty)
                {
                    Console.WriteLine(output);
                }
                token = Console.ReadLine();
            }
        }
        static string IsItNilapdrome(string token)
        {
            string result = string.Empty;
            if (token.Length < 3)
            {
                //Console.WriteLine("too short");
                return result;
            }
            for (int i = 1; i < token.Length/2; i++)
            {
                string firstPart = token.Substring(0, i);
                string secondPart = token.Substring(token.Length - i, i);
                if (firstPart!=secondPart)
                {
                    if (firstPart.Length<2)
                    {
                        return result;
                    }
                    else
                    {
                        string core = token.Substring(i-1, token.Length+1-i);
                        return core + firstPart + core;
                    }
                }
            }
            //else if (token[0]!=token[token.Length-1])
            //{
            //    //Console.WriteLine("frst!=last");
            //    return result;
            //}
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < token.Length/2; i++)
            //{
            //    if (token[i]==token[token.Length-1-i])
            //    {
            //        sb.Append(token[i]);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //string borderLeft = sb.ToString();
            //string core = token.Remove(0, borderLeft.Length);
            //core = core.Remove(core.Length - borderLeft.Length, borderLeft.Length);
            //if (core==string.Empty)
            //{
            //    return null;
            //}
            //result = core + borderLeft + core;
            return result;
        }
    }
}
