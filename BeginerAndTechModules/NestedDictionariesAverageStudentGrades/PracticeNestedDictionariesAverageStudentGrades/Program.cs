using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeNestedDictionariesAverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentRecords = new Dictionary<string, List<double>>();

            int counts = int.Parse(Console.ReadLine());

            for (int i = 0; i < counts; i++)
            {
                string[] inputString = Console.ReadLine().Split(' ').ToArray();

                string name = inputString[0];
                double grade = double.Parse(inputString[1]);

                if (studentRecords.ContainsKey(name))
                {
                    studentRecords[name].Add(grade);
                }
                else
                {
                    studentRecords[name] = new List<double> { grade };
                }
            }

            foreach (KeyValuePair<string, List<double>> item in studentRecords)
            {
                double average = GetAveradge(item.Value);
                Console.WriteLine("{0} ->{1:f2} (avg: {2:f2})", item.Key, GetStringOfDoubles(item.Value), average);
            }
        }
        static double GetAveradge(List<double> grades)
        {
            double result = 0;
            foreach (double grade in grades)
            {
                result += grade;
            }
            result = result / grades.Count;
            return result;
        }

        static string GetStringOfDoubles(List<double> values)
        {
            string result = null;
            foreach (var item in values)
            {
                result = result + " " + item.ToString("f2");
            }
            return result;
        }
    }
}
