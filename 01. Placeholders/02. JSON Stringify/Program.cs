using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.JSON_Stringify
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var students = new List<Student>();

            while (input != "stringify")
            {
                var tokens = input.Split(new[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var grades = tokens.Skip(2).Select(int.Parse).ToList();

                var newStudent = new Student();

                newStudent.Name = name;
                newStudent.Age = age;
                newStudent.Grades = grades;

                students.Add(newStudent);

                input = Console.ReadLine();
            }

            var output = "";
            output += "[";

            for (int i = 0; i < students.Count; i++)
            {
                var currentStudent = students[i];

                output += "{";
                output += "name:\"" + currentStudent.Name + "\"" + ",";
                output += "age:" + currentStudent.Age + ",";
                output += "grades:[" + string.Join(", ", currentStudent.Grades) + "]";

                output += "}";

                if (i < students.Count - 1)
                {
                    output += ",";
                }
            }

            output += "]";

            Console.WriteLine(output);
        }
    }
}
