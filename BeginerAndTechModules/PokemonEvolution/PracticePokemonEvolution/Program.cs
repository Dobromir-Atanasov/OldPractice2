using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePokemonEvolution
{
    class Program
    {
        public static string stopString = "wubbalubbadubdub";
        // print
        // sort
        // parse console line

        
        static void Main(string[] args)
        {
            string inString = null;
            List<Pokemon> pokemons = new List<Pokemon>();

            Pokemon A = new Pokemon("a");
            A.evolutions.Add("aaa");
            A.index.Add(1);
            A.evolutions.Add("aaa1");
            A.index.Add(1);
            pokemons.Add(A);

            Pokemon B = new Pokemon("b");
            B.evolutions.Add("bbb");
            B.index.Add(1);
            B.evolutions.Add("bbb1");
            B.index.Add(2);
            pokemons.Add(B);

            Pokemon C = new Pokemon("c");
            C.evolutions.Add("ccc3");
            C.index.Add(3);
            C.evolutions.Add("ccc3");
            C.index.Add(3);
            pokemons.Add(C);

            foreach (Pokemon item in pokemons)
            {
                Console.WriteLine(item.PrintAll());
            }

            inString.Spl
            do
            {
                inString = Console.ReadLine();
                if (inString != stopString)
                {
                    
                }
            
            } while (inString == stopString);

            // sort

            // print
        }
    }
    class Pokemon
    {
        public string name;
        public List<string> evolutions;
        public List<int> index;

        public Pokemon(string _name)
        {
            this.name = _name;
            evolutions = new List<string>();
            index = new List<int>();
        }
        public string PrintAll()
        {
            string output = "# " + name + "\n";
            for (int i = 0; i < evolutions.Count; i++)
            {
                output = output + evolutions[i] + " <-> " + index[i] + "\n";
            }
            return output;
        }
    }    

}
