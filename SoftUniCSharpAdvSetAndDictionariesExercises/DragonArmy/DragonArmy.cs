using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// so far 50/100
// I  need to find a way to replace existing dragons, isntead of adding them

namespace DragonArmy
{
    class DragonArmy
    {
        public class Dragon
        {
            public string Name { get; set; }
            public int Damage { get; set; }
            public int Health { get; set; }
            public int Armor { get; set; }
        }
        public static Dictionary<string, List<Dragon>> dragonNest = new Dictionary<string, List<Dragon>>();
        static void Main(string[] args)
        {
            int numberOfInputLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfInputLines; i++)
            {
                InputData();
            }
            Output();
        }
        static void Output()
        {
            foreach (var item in dragonNest)
            {
                string dragonType = item.Key;
                double avDmg = 0;
                double avHealth = 0;
                double avArmor = 0;
                int numberOfDragonsOfThatType = 0;
                foreach (var dragon in item.Value)
                {
                    avDmg += dragon.Damage;
                    avHealth += dragon.Health;
                    avArmor += dragon.Armor;
                    numberOfDragonsOfThatType++;
                }
                avDmg /= numberOfDragonsOfThatType;
                avHealth /= numberOfDragonsOfThatType;
                avArmor /= numberOfDragonsOfThatType;
                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})", dragonType, avDmg, avHealth, avArmor);
                foreach (var dragon in item.Value.OrderBy(x=>x.Name))
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", dragon.Name, dragon.Damage, dragon.Health, dragon.Armor);
                }
            }
        }
        static void InputData()
        {
            string[] tokenInput = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string dragonType = tokenInput[0];
            Dragon currentDragon = new Dragon();
            currentDragon.Name = tokenInput[1];
            if (tokenInput[2]=="null")
            {
                currentDragon.Damage = 45;
            }
            else
            {
                currentDragon.Damage = int.Parse(tokenInput[2]);
            }
            if (tokenInput[3] == "null")
            {
                currentDragon.Health = 250;
            }
            else
            {
                currentDragon.Health = int.Parse(tokenInput[3]);
            }
            if (tokenInput[4] =="null")
            {
                currentDragon.Armor = 10;
            }
            else
            {
                currentDragon.Armor = int.Parse(tokenInput[4]);
            }
            if (!dragonNest.ContainsKey(dragonType))
            {
                dragonNest.Add(dragonType, new List<Dragon>());
                dragonNest[dragonType].Add(currentDragon);  //HOW TO REPLACE EXISTING DRAGON NAME?
            }
            else
            {
                dragonNest[dragonType].Add(currentDragon);
            }
        }
    }
}
