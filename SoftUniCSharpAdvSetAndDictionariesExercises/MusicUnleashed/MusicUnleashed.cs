using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicUnleashed
{
    class MusicUnleashed
    {
        public static Dictionary<string, Dictionary<string, long>> database = new Dictionary<string, Dictionary<string, long>>();
        static void Main(string[] args)
        {
            string tokenInput = Console.ReadLine();
            while (tokenInput.ToLower() != "end")
            {
                InputData(tokenInput);
                tokenInput = Console.ReadLine();
            }
            Output();
        }
        static void Output()
        {
            foreach (var place in database)
            {
                Console.WriteLine(place.Key);
                foreach (var singer in place.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", singer.Key, singer.Value);
                }
            }
        }
        static void InputData(string inputData)
        {
            if (IsInputCorrect(inputData))
            {
                string[] token = inputData.Split(' ');
                string name = token[0];
                int placeStartingPosition = 0;
                string place = string.Empty;
                int ticketPrice = int.Parse(token[token.Length - 2]);
                int ticketCount = int.Parse(token[token.Length - 1]);
                for (int i = 1; i < 4; i++)
                {
                    if (token[i][0] != '@')
                    {
                        name = name + " " + token[i];
                    }
                    else
                    {
                        placeStartingPosition = i;
                        break; //name ended, place started at i position
                    }
                }
                place = token[placeStartingPosition].Substring(1); //Removing "@"
                for (int i = placeStartingPosition + 1; i < token.Length - 2; i++)
                {
                    place = place + " " + token[i];
                }
                PutDataToDict(name, place, ticketPrice, ticketCount);
            }
        }
        static void PutDataToDict(string name, string place, int price, int count)
        {
            if (!database.ContainsKey(place))
            {
                database.Add(place, new Dictionary<string, long>());
                database[place].Add(name, price * count);
            }
            else
            {
                if (!database[place].ContainsKey(name))
                {
                    database[place].Add(name, price * count);
                }
                else
                {
                    database[place][name] += price * count;
                }
            }
        }
        static bool IsInputCorrect(string inputData)
        {
            bool isInputCorrect = true;
            string[] token = inputData.Split(' ');
            if (token.Length < 4)
            {
                isInputCorrect = false;
            }
            try
            {
                if (!(token[1][0] == '@' || token[2][0] == '@' || token[3][0] == '@'))
                {
                    isInputCorrect = false;
                }
                int.Parse(token[token.Length - 1]);
                int.Parse(token[token.Length - 2]);
            }
            catch (Exception)
            {
                isInputCorrect = false;
            }
            if (isInputCorrect)
            {
                // Console.WriteLine("passed");
                return isInputCorrect;
            }
            else
            {
                // Console.WriteLine("failed");
                return isInputCorrect;
            }
        }
    }
}
