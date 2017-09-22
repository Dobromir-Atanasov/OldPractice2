using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectsSimpleClassesAnimals
{
    class Program
    {
        public class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int NumberOfLegs { get; set; }
            public void ProduceSound()
            {
                Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
            }
        }
        public class Cat
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int IntelligenceQuotient { get; set; }
            public void ProduceSound()
            {
                Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
            }
        }
        public class Snake
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int CrueltyCoefficient { get; set; }
            public void ProduceSound()
            {
                Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
            }
        }
        public static List<Dog> Dogs = new List<Dog>();
        public static List<Cat> Cats = new List<Cat>();
        public static List<Snake> Snakes = new List<Snake>();
        static void Main(string[] args)
        {
            GetDataFromConsole();
            PrintData();
        }
        static void PrintData()
        {
            foreach (var item in Dogs)
            {
                Console.WriteLine("Dog: {0}, Age: {1}, Number Of Legs: {2}", item.Name, item.Age, item.NumberOfLegs);
            }
            foreach (var item in Cats)
            {
                Console.WriteLine("Cat: {0}, Age: {1}, IQ: {2}", item.Name, item.Age, item.IntelligenceQuotient);
            }
            foreach (var item in Snakes)
            {
                Console.WriteLine("Snake: {0}, Age: {1}, Cruelty: {2}", item.Name, item.Age, item.CrueltyCoefficient);
            }
        }
        static void GetDataFromConsole()
        {
            string[] tokensInput = Console.ReadLine()
                .Split(' ')
                .ToArray();

            while (tokensInput[0] != "I'm")
            {
                if (tokensInput[0] == "talk")
                {
                    string nameToTalk = tokensInput[1];
                    ProduceSound(nameToTalk);
                }
                else
                {
                    string inputClass = tokensInput[0];
                    string inputName = tokensInput[1];
                    int inputAge = int.Parse(tokensInput[2]);
                    int inputParameter = int.Parse(tokensInput[3]);
                    PutInClassList(inputClass, inputName, inputAge, inputParameter);
                }
                tokensInput = Console.ReadLine()
                .Split(' ')
                .ToArray();
            }
        }
        static void ProduceSound(string classType)
        {
            foreach (var item in Dogs)
            {
                if (item.Name==classType)
                {
                    var dogTalk = new Dog();
                    dogTalk.ProduceSound();
                }
            }
            foreach (var item in Cats)
            {
                if (item.Name==classType)
                {
                    var catTalk = new Cat();
                    catTalk.ProduceSound();
                }
            }
            foreach (var item in Snakes)
            {
                if (item.Name==classType)
                {
                    var snakeTalk = new Snake();
                    snakeTalk.ProduceSound();
                }
            }
        }
        static void PutInClassList(string inputClass, string inputName, int inputAge, int inputParameter)
        {
            switch (inputClass)
            {
                case "Dog":
                    Dogs.Add(new Dog { Name = inputName, Age = inputAge, NumberOfLegs = inputParameter });
                    break;
                case "Cat":
                    Cats.Add(new Cat { Name = inputName, Age = inputAge, IntelligenceQuotient = inputParameter });
                    break;
                case "Snake":
                    Snakes.Add(new Snake { Name = inputName, Age = inputAge, CrueltyCoefficient = inputParameter });
                    break;
                default:
                    break;
            }
        }
    }
}
