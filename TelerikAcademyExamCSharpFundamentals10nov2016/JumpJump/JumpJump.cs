using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpJump
{
    class JumpJump
    {
        static void Main(string[] args)
        {
            char[] tokenInput = Console.ReadLine().ToCharArray();
            int currentPosition = 0;
            char command = tokenInput[currentPosition];
            bool keepJumping = true;
            while (keepJumping)
            {
                if (command == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", currentPosition);
                    keepJumping = false;
                    break;
                }
                else if (command == '0')
                {
                    Console.WriteLine("Too drunk to go on after {0}!", currentPosition);
                    keepJumping = false;
                    break;
                }
                else if (int.Parse(command.ToString()) % 2 != 0)
                {
                    int steps = int.Parse(command.ToString());
                    if ((currentPosition - steps) < 0)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", currentPosition - steps);
                        keepJumping = false;
                        break;
                    }
                    else
                    {
                        currentPosition -= steps;
                    }
                }
                else
                {
                    int steps = int.Parse(command.ToString());
                    if ((currentPosition + steps) > tokenInput.Length - 1)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", currentPosition + steps);
                        keepJumping = false;
                        break;
                    }
                    else
                    {
                        currentPosition += steps;
                    }
                }
                command = tokenInput[currentPosition];
            }

            //foreach (var item in tokenInput)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
