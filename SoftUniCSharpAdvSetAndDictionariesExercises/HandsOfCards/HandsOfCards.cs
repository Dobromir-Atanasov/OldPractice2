using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> players = new Dictionary<string, HashSet<string>>();
            //Input data
            string tokenInput = Console.ReadLine();
            while (tokenInput.ToLower() != "joker")
            {
                PutToDictionary(tokenInput, players);
                tokenInput = Console.ReadLine();
            }
            //Print the result
            foreach (var player in players)
            {
                Console.WriteLine("{0}: {1}", player.Key, Scores(player.Value));
            }
        }
        static int Scores(HashSet<string> cards)
        {
            int result = 0;
            foreach (var card in cards)
            {
                result += CardValue(card);
            }
            return result;
        }
        static int CardValue(string card)
        {
            int result = 0;
            char cardType = card[0];
            char cardColor = card[card.Length-1];
            switch (cardType) //value by card type
            {
                case '1': //card 10
                    result = 10;
                    break;
                case 'J':
                    result = 11;
                    break;
                case 'Q':
                    result = 12;
                    break;
                case 'K':
                    result = 13;
                    break;
                case 'A':
                    result = 14;
                    break;
                default: //case 2-9
                    result = cardType-48; //ascii code - 48
                    break;
            }
            switch (cardColor) //value by card color
            {
                case 'S':
                    result *= 4;
                    break;
                case 'H':
                    result *= 3;
                    break;
                case 'D':
                    result *= 2;
                    break;
                case 'C':
                    result *= 1;
                    break;
                default:
                    break;
            }
            return result;
        }
        static void PutToDictionary(string token, Dictionary<string, HashSet<string>> players)
        {
            string[] splitByDoubleDot = token.Split(':').ToArray();
            string name = splitByDoubleDot[0];
            string[] splitByComa = splitByDoubleDot[1]
                .Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            if (!players.ContainsKey(name))
            {
                players.Add(name, new HashSet<string>());
            }
            foreach (var card in splitByComa)
            {
                players[name].Add(card);
            }
        }
    }
}
