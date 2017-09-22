using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            string[] tokenInput = Console.ReadLine().Split('-').ToArray();
            while (tokenInput[0].ToLower()!= "search")
            {
                if (!phonebook.ContainsKey(tokenInput[0]))
                {
                    phonebook.Add(tokenInput[0], tokenInput[1]);
                }
                else
                {
                    phonebook[tokenInput[0]] = tokenInput[1];
                }
                tokenInput = Console.ReadLine().Split('-').ToArray();
            }
            string nameToSearch = Console.ReadLine();
            while (nameToSearch.ToLower()!="stop")
            {
                if (phonebook.ContainsKey(nameToSearch))
                {
                    Console.WriteLine("{0} -> {1}", nameToSearch, phonebook[nameToSearch]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", nameToSearch);
                }
                nameToSearch = Console.ReadLine();
            }
        }
    }
}
