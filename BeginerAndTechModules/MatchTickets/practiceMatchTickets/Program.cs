using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceMatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = Decimal.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            decimal peopleNumber = Decimal.Parse(Console.ReadLine());
            decimal vipPrice = 499.99m;
            decimal normalPrice = 249.99m;
            decimal ticketPrice = 0m;

            decimal budgetAvailable = 0m;
            if (peopleNumber <= 4)
            {
                budgetAvailable = budget * .25m;
            }
            else 
            {
                if (peopleNumber <= 9)
                {
                    budgetAvailable = budget * .40m;
                }
                else
                    {
                    if (peopleNumber <= 24)
                    {
                        budgetAvailable = budget * .50m;
                    }
                    else
                        {
                        if (peopleNumber <= 49)
                        {
                            budgetAvailable = budget * .60m;
                        }
                        else
                        {
                            budgetAvailable = budget * .75m;
                        }
                    }
                }
            }
            if (category == "VIP")
            {
                ticketPrice = vipPrice;
            }
            else
            {
                ticketPrice = normalPrice;
            }

            if ((budgetAvailable - (ticketPrice * peopleNumber)) >= 0) {
                Console.WriteLine("Yes! You have {0:f2} leva left", (budgetAvailable - (ticketPrice * peopleNumber)));
            }
            else
                Console.WriteLine("Not enough money! You need {0:f2} leva.", (-1m*(budgetAvailable - (ticketPrice * peopleNumber))));

        }
    }
}
