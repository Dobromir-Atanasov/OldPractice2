using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRegexmon
{
    class Program
    {
        public static bool didimonTurn = true;
        public static string playString = null;
        public static bool stringFound = false;
        static void Main(string[] args)
        {
            playString = "^^^^pika-pika^^^^"; // playString = Console.ReadLine();

            do
            {
                if (didimonTurn==true)
                {
                    DidimonPlay();
                    didimonTurn = false;
                }
                else
                {
                    BojomonPlay();
                    didimonTurn = false;
                }
            } while (playString == null);
        }

        public static void DidimonPlay()
        {
            // Looking for didimon string to play
            do
            {

                
            } while (stringFound != true);
        
        }

        public static void BojomonPlay()
        { 
        
        }
    }
}
