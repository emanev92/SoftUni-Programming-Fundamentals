using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Dict_Ref
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var nameValue = new Dictionary<string, int>();


            while (input != "end")
            {
                var splittedInput = input.Split();
                var firstElement = splittedInput[0];
                var lastElement = splittedInput[splittedInput.Length - 1];
                var number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    nameValue[firstElement] = number;
                }
                else
                {
                    if (nameValue.ContainsKey(lastElement))
                    {
                        var referencedValue = nameValue[lastElement];
                        nameValue[firstElement] = referencedValue;
                    }
                }

                input = Console.ReadLine();
            }


            foreach (var name in nameValue)
            {
                Console.WriteLine($"{name.Key} === {name.Value}");
            }


        }
    }
}
