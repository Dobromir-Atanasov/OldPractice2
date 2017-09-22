using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeNeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDmg = int.Parse(Console.ReadLine());
            int goshoDmg = int.Parse(Console.ReadLine());

            int peshoHealt = 100;
            int goshoHealt = 100;

            bool playerDead = false;

            int turnNumber = 0;

            string playerWhoWon = "Pesho";

            do
            {
                turnNumber++;
                if (turnNumber % 2 != 0)
                {
                    goshoHealt = goshoHealt - peshoDmg;
                    if (goshoHealt>0)
                    {
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealt);
                    }
                }
                else
                {
                    peshoHealt = peshoHealt - goshoDmg;
                    if (peshoHealt>0)
                    {
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealt);
                    }
                }
                if (goshoHealt <= 0 || peshoHealt <= 0)
                {
                    playerDead = true;
                    if (goshoHealt > peshoHealt)
                    {
                        playerWhoWon = "Gosho";
                    }
                }
                else
                {
                    if (turnNumber % 3 == 0)
                    {
                        goshoHealt += 10;
                        peshoHealt += 10;
                    }
                }

            } while (playerDead!=true);
            Console.WriteLine("{0} won in {1}th round.", playerWhoWon, turnNumber);
        }
    }
}
