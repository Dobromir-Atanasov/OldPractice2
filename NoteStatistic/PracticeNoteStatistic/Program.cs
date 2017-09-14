using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeNoteStatistic
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitSeparator = new char[] { ' ' };
            List<string> inputData = Console.ReadLine()
                .Split(splitSeparator, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            for (int i = 0; i < inputData.Count; i++)
            {
                inputData[i] = double.Parse(inputData[i]).ToString("F2");
            }
            List<string> notes = new List<string>();
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();
            double naturalsSum = 0;
            double sahrpsSum = 0;

            foreach (var item in inputData)
            {
                switch (item)
                {
                    case "261.63":
                        notes.Add("C");
                        naturals.Add("C");
                        naturalsSum += 261.63;
                        break;
                    case "277.18":
                        notes.Add("C#");
                        sharps.Add("C#");
                        sahrpsSum += 277.18;
                        break;
                    case "293.66":
                        notes.Add("D");
                        naturals.Add("D");
                        naturalsSum += 293.66;
                        break;
                    case "311.13":
                        notes.Add("D#");
                        sharps.Add("D#");
                        sahrpsSum += 311.13;
                        break;
                    case "329.63":
                        notes.Add("E");
                        naturals.Add("E");
                        naturalsSum += 329.63;
                        break;
                    case "349.23":
                        notes.Add("F");
                        naturals.Add("F");
                        naturalsSum += 349.23;
                        break;
                    case "369.99":
                        notes.Add("F#");
                        sharps.Add("F#");
                        sahrpsSum += 369.99;
                        break;
                    case "392.00":
                        notes.Add("G");
                        naturals.Add("G");
                        naturalsSum += 392.00;
                        break;
                    case "415.30":
                        notes.Add("G#");
                        sharps.Add("G#");
                        sahrpsSum += 415.30;
                        break;
                    case "440.00":
                        notes.Add("A");
                        naturals.Add("A");
                        naturalsSum += 440.00;
                        break;
                    case "466.16":
                        notes.Add("A#");
                        sharps.Add("A#");
                        sahrpsSum += 466.16;
                        break;
                    case "493.88":
                        notes.Add("B");
                        naturals.Add("B");
                        naturalsSum += 493.88;
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine("Notes: " + string.Join(" ", notes));
            Console.WriteLine("Naturals: " + string.Join(", ", naturals));
            Console.WriteLine("Sharps: " + string.Join(", ", sharps));
            Console.WriteLine("Naturals sum: " + naturalsSum);
            Console.WriteLine("Sharps sum: " + sahrpsSum);
        }
    }
}
