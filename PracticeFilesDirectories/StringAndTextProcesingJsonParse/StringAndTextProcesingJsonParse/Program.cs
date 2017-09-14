using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndTextProcesingJsonParse
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }

    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Input();
            Output();
        }
        static void Output()
        {
            Console.Write("[");
            for (int i = 0; i < students.Count; i++)
            {
                Student student = students[i];
                StringBuilder sb = new StringBuilder();
                sb.Append("{name:\"").Append(student.Name).Append("\",age:").Append(student.Age).Append(",grades:[").Append(string.Join(", ", student.Grades)).Append("]}");
                Console.Write(sb);
                if (i < students.Count - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");
        }
        static void Input()
        {
            string tokenInput = Console.ReadLine();
            while (tokenInput != "stringify")
            {
                string[] tokens = tokenInput
                    .Split(new char[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Student curentStudent = new Student();

                curentStudent.Name = tokens[0];
                curentStudent.Age = int.Parse(tokens[1]);
                curentStudent.Grades = tokens.Skip(2).Select(x => int.Parse(x)).ToList();

                students.Add(curentStudent);
                tokenInput = Console.ReadLine();
            }
        }
    }
}
