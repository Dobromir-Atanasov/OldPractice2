using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndTextProcesingJsonParse2
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }
    class Program
    {
        public static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            string token = Console.ReadLine();
            token = token.Substring(2, token.Length - 2);
            token = token.Substring(0, token.Length - 2);
            string[] splitedToStudents = Splitter(token, "},{");
            for (int i = 0; i < splitedToStudents.Length; i++)
            {
                string[] splitedStudent = splitedToStudents[i]
                    .Split(new string[] { "name:\"", "\",age:", ",grades:[", "]" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Student currentStudent = new Student();
                currentStudent.Name = splitedStudent[0];
                currentStudent.Age = int.Parse(splitedStudent[1]);
                if (splitedStudent.Length > 2)
                {
                    currentStudent.Grades = splitedStudent[2]
                        .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToList();
                }
                if (currentStudent.Grades!=null)
                {
                    Console.WriteLine("{0} : {1} -> {2}", currentStudent.Name, currentStudent.Age, string.Join(", ", currentStudent.Grades));
                }
                else
                {
                    Console.WriteLine("{0} : {1} -> None", currentStudent.Name, currentStudent.Age);
                }
            }
        }
        static string[] Splitter(string toSplit, string splitter)
        {
            string[] result = toSplit
                .Split(new string[] { splitter }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            return result;
        }
    }
}
