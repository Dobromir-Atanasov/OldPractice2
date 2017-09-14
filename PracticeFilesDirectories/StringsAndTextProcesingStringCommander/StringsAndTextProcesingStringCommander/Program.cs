using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndTextProcesingStringCommander
{
    class Program
    {
        static void Main(string[] args)
        {
            string manipulate = Console.ReadLine();
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] tokens = command.Split(' ');
                switch (tokens[0])
                {
                    case "Left":
                        {
                            int count = int.Parse(tokens[1]) % manipulate.Length; //remove unnecesary cycles
                            for (int i = 0; i < count; i++)
                            {
                                string elementToMove = manipulate.ElementAt(0).ToString();
                                manipulate = manipulate.Remove(0, 1);
                                manipulate = manipulate.Insert(manipulate.Length, elementToMove);
                            }
                        }
                        break;
                    case "Right":
                        {
                            int count = int.Parse(tokens[1]) % manipulate.Length; //remove unnecesary cycles
                            for (int i = 0; i < count; i++)
                            {
                                string elementToMove = manipulate.ElementAt(manipulate.Length-1).ToString();
                                manipulate = manipulate.Remove(manipulate.Length - 1, 1);
                                manipulate = manipulate.Insert(0, elementToMove);
                            }
                        }
                        break;
                    case "Insert":
                        {
                            int startIndex = int.Parse(tokens[1]);
                            string stringToInsert = tokens[2];
                            manipulate = manipulate.Insert(startIndex, stringToInsert);
                        }
                        break;
                    case "Delete":
                        {
                            int startIndex = int.Parse(tokens[1]);
                            int endIndex = int.Parse(tokens[2])+1;
                            manipulate = manipulate.Remove(startIndex, endIndex);
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(manipulate);
        }
    }
}
