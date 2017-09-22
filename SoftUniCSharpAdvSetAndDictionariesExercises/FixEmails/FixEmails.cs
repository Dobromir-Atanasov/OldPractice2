using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {

            var emailBook = new Dictionary<string, string>();
            string name = Console.ReadLine();
            string email = string.Empty;
            while (name.ToLower()!="stop")
            {
                email = Console.ReadLine();
                if (isItValid(email))
                {
                    if (!emailBook.ContainsKey(name))
                    {
                        emailBook.Add(name, email);
                    }
                    else
                    {
                        emailBook[name] = email;
                    }
                }
                name = Console.ReadLine();
            }
            foreach (var token in emailBook)
            {
                Console.WriteLine("{0} -> {1}", token.Key, token.Value);
            }
        }
        static bool isItValid(string email)
        {
            bool result = true;
            string[] splitByA = email.Split('@').ToArray();
            string[] splitToDomain = splitByA[splitByA.Length - 1].Split('.').ToArray();
            if (splitToDomain[splitToDomain.Length - 1] == "us" || splitToDomain[splitToDomain.Length-1] == "uk")
            {
                result = false;
            }

            return result;
        }
    }
}
