using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Object_and_Classes___Exercises
{
    public class Exercises01
    {
        public string topic { get; set; }
        public string courseName { get; set; }
        public string judgeLink { get; set; }
        public List<string> problems { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var exercises = new List<Exercises01>();

            while (input != "go go go")
            {
                var tokens = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var topic = tokens[0];
                var courseName = tokens[1];
                var judgeLink = tokens[2];
                List<string> problems = tokens.Skip(3).ToList();

                var newExercise = new Exercises01();

                newExercise.topic = topic;
                newExercise.courseName = courseName;
                newExercise.judgeLink = judgeLink;
                newExercise.problems = problems;

                exercises.Add(newExercise);
                

                input = Console.ReadLine();

            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.courseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.judgeLink}");
                

                var count = 1;

                foreach (var problem in exercise.problems)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;
                }
            }


        }
    }
}
