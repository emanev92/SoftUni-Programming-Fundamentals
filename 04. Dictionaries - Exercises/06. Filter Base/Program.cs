using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.Filter_Base
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var namesAndAges = new Dictionary<string, int>();
            var namesAndPositions = new Dictionary<string, string>();
            var namesAndSalaries = new Dictionary<string, double>();

            while (input != "filter base")
            {
                var tokens = input.Split(' ');
                var name = tokens[0];
                var info = tokens[tokens.Length - 1];

                var age = 0;
                double salary = 0;
               


                if (int.TryParse(info, out age))
                {
                    namesAndAges[name] = age;
                }
                else if (double.TryParse(info, out salary))
                {
                    namesAndSalaries[name] = salary;
                }
                else
                {
                    
                    namesAndPositions[name] = info;
                }

                input = Console.ReadLine();

            }

            input = Console.ReadLine();

            if (input == "Age")
            {
                foreach (var man in namesAndAges)
                {
                    Console.WriteLine($"Name: {man.Key}");
                    Console.WriteLine($"Age: {man.Value}");
                    Console.WriteLine("====================");
                }
            }

            else if (input == "Salary")
            {
                foreach (var man in namesAndSalaries)
                {
                    Console.WriteLine($"Name: {man.Key}");
                    Console.WriteLine("Salary: {0:f2}", man.Value);
                    Console.WriteLine("====================");
                }
            }
            
            else if (input == "Position")
            {
                foreach (var man in namesAndPositions)
                {
                    Console.WriteLine($"Name: {man.Key}");
                    Console.WriteLine($"Position: {man.Value}");
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
