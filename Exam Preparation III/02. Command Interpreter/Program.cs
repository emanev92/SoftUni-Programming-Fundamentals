using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main()
        {
            List<string> array = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = Console.ReadLine();

            while (command != "end")
            {

                var tokens = command.Split(' ');
                var commands = tokens[0];

                switch (commands)
                {
                    case "reverse":
                        var startReverse = int.Parse(tokens[2]);
                        var countReverse = int.Parse(tokens[4]);

                        if (isValid(array, startReverse, countReverse)) 
                        {
                            Reverse(array, startReverse, countReverse);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    case "sort":
                        var startSort = int.Parse(tokens[2]);
                        var countSort = int.Parse(tokens[4]);

                        if (isValid(array, startSort, countSort))
                        {
                            Sort(array, startSort, countSort);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollLeft":
                        var countLeft = int.Parse(tokens[1]);

                        if (countLeft >= 0)
                        {
                            RollLeft(array, countLeft);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    case "rollRight":
                        var countRight = int.Parse(tokens[1]);

                        if (countRight >= 0)
                        {

                            RollRight(array, countRight);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

     

        private static void Reverse(List<string> array, int startReverse, int countReverse)
        {
            array.Reverse(startReverse, countReverse);
        }

        private static void Sort(List<string> array, int startSort, int countSort)
        {
            array.Sort(startSort, countSort, null);
        }

        private static void RollRight(List<string> array, int countRight)
        {
            int rotation = countRight % array.Count;

            for (int i = 0; i < rotation; i++)
            {
                var lastElement = array[array.Count - 1];

                for (int j = array.Count - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }

                array[0] = lastElement;
            }
        }

        private static void RollLeft(List<string> array, int countLeft)
        {
            int rotation = countLeft % array.Count;

            for (int i = 0; i < rotation; i++)
            {
                var firstElement = array[0];

                for (int j = 0; j < array.Count - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Count - 1] = firstElement;
            }
        }

        private static bool isValid(List<string> array, int start, int count)
        {
            bool result = start >= 0 && start < array.Count && count >= 0 && (count + start) <= array.Count;

            return result;
        }
    }
}
