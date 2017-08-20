using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }

    public int Age { get; set; }

    public List<int> Grades { get; set; }
}

public class JSONparse
{
    public static void Main()
    {
        var inputLine = Console.ReadLine().Split(new[] { "},{" },
                StringSplitOptions.RemoveEmptyEntries);

        var students = new List<Student>();

        for (int i = 0; i < inputLine.Length; i++)
        {
            var tokens = inputLine[i].Split(new[] { '{', '[', ':', '"', '}', ']', ',', ' ' }
            , StringSplitOptions.RemoveEmptyEntries);

            var name = tokens[1];
            var age = int.Parse(tokens[3]);
            var grades = tokens.Skip(5).ToList();

            var newStudent = new Student
            {
                Name = name,
                Age = age,
                Grades = grades.Select(int.Parse).ToList()
            };

            students.Add(newStudent);
        }

        foreach (var student in students)
        {
            if (student.Grades.Count != 0)
            {
                Console.WriteLine("{0} : {1} -> {2}", student.Name, student.Age, string.Join(", ", student.Grades));
            }
            else
            {
                Console.WriteLine("{0} : {1} -> None", student.Name, student.Age);
            }
        }
    }
}