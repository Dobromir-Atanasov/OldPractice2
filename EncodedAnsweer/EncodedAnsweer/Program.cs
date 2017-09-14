using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnsweer
{
    class Program
    {
        static void Main(string[] args)
        {
            int answerA = 0;
            int answerB = 0;
            int answerC = 0;
            int answerD = 0;
            uint currentAnswer = 0;
            string theString = "";

            //input
            int numberOfQuestions = int.Parse(Console.ReadLine());
            
            //Calculations
            for (int i = 0; i < numberOfQuestions; i++)
            {
                currentAnswer = UInt32.Parse(Console.ReadLine())%4;
                switch (currentAnswer)
                {
                    case 0:
                        {
                            theString = theString + "a ";
                            answerA++;
                            break;
                        }
                    case 1:
                        {
                            theString = theString + "b ";
                            answerB++;
                            break;
                        }
                    case 2:
                        {
                            theString = theString + "c ";
                            answerC++;
                            break;
                        }
                    case 3:
                        {
                            theString = theString + "d ";
                            answerD++;
                            break;
                        }


                }
                
            }
            Console.WriteLine(theString);
            Console.WriteLine("Answer A: {0}", answerA);
            Console.WriteLine("Answer B: {0}", answerB);
            Console.WriteLine("Answer C: {0}", answerC);
            Console.WriteLine("Answer D: {0}", answerD);

            //Output
        }
    }
}
