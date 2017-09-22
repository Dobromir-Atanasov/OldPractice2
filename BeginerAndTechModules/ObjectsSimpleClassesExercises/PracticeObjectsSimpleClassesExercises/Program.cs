using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectsSimpleClassesExercises
{
    class Program
    {
        public class Exercise
        {
            public string Topic { get; set; }
            public string CourseName { get; set; }
            public string JudgeContestLink { get; set; }
            public List<string> Problems { get; set; }

        }
        static List<Exercise> exercises = new List<Exercise>();
        static void Main(string[] args)
        {
            GetDataFromConsole();
            PrintResult();
        }
        static void PrintResult()
        {
            foreach (var item in exercises)
            {
                Console.WriteLine("Exercises: {0}", item.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", item.CourseName);
                Console.WriteLine("Check your solutions here: {0}", item.JudgeContestLink);
                int counter = 1;
                foreach (var exerciseName in item.Problems)
                {
                    Console.WriteLine("{0}. {1}", counter, exerciseName);
                    counter++;
                }
            }
        }
        static void GetDataFromConsole()
        {
            string[] tokensInput = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (tokensInput[0] != "go go go")
            {
                string topic = tokensInput[0];
                string course = tokensInput[1];
                string judgeConstestLink = tokensInput[2];
                string[] problems = tokensInput[3]
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                exercises.Add(new Exercise { Topic = topic, CourseName = course, JudgeContestLink = judgeConstestLink, Problems = new List<string>(problems.ToList()) });

                tokensInput = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
        }
    }
}
