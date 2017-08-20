using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];

                if (command == "exchange")
                {
                    var index = int.Parse(tokens[1]);

                    Exchange(array, index);

                }

                else if (command == "max")
                {
                    var oddOrEven = tokens[1];

                    if (oddOrEven == "odd")
                    {
                        Odd(array);
                    }
                    else if (oddOrEven == "even")
                    {
                        Even(array);
                    }
                }

                else if (command == "min")
                {
                    var oddOrEven = tokens[1];

                    if (oddOrEven == "odd")
                    {
                        OddMin(array);
                    }
                    else if (oddOrEven == "even")
                    {
                        EvenMin(array);
                    }
                }

                else if (command == "first")
                {
                    int count = int.Parse(tokens[1]);
                    var oddOrEven = tokens[2];

                    if (oddOrEven == "odd")
                    {
                        FirstOdd(array, count);
                    }
                    else if (oddOrEven == "even")
                    {
                        FirstEven(array, count);
                    }

                }

                else if (command == "last")
                {

                    int count = int.Parse(tokens[1]);
                    var oddOrEven = tokens[2];

                    if (oddOrEven == "odd")
                    {
                        LastOdd(array, count);
                    }
                    else if (oddOrEven == "еven")
                    {
                        LastEven(array, count);
                    }
                }

                input = Console.ReadLine();
            }


            Console.WriteLine("[" + string.Join(", ", array) + "]");


        }

        private static void LastEven(List<int> array, int count)
        {
            if (!array.Any(x => x % 2 == 0))
            {
                Console.WriteLine("[]");
                return;
            }

            if (count > array.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
                return;

            }

            var evenElements = array.Where(x => x % 2 == 0).Reverse().Take(count).Reverse().ToList();
            Console.WriteLine("[" + string.Join(", ", evenElements) + "]");
        }

        private static void LastOdd(List<int> array, int count)
        {
            if (count > array.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (!array.Any(x => x % 2 != 0))
            {
                Console.WriteLine("[]");
                return;
            }

            var oddElements = array.Where(x => x % 2 != 0).Reverse().Take(count).Reverse().ToList();
            Console.WriteLine("[" + string.Join(", ", oddElements) + "]");
        }

        private static void FirstEven(List<int> array, int count)
        {
            if (count > array.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
                return;

            }

            if (!array.Any(x => x % 2 == 0))
            {
                Console.WriteLine("[]");
                return;
            }

            var evenElements = array.Where(x => x % 2 == 0).Take(count).ToList();
            Console.WriteLine("[" + string.Join(", ", evenElements) + "]");


        }

        private static void FirstOdd(List<int> array, int count)
        {

            if (count > array.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (!array.Any(x => x % 2 != 0))
            {
                Console.WriteLine("[]");
                return;
            }

            var oddElements = array.Where(x => x % 2 != 0).Take(count).ToList();
            Console.WriteLine("[" + string.Join(", ", oddElements) + "]");
        }

        private static void EvenMin(List<int> array)
        {
            if (!array.Any(x => x % 2 == 0))
            {
                Console.WriteLine("No matches");
                return;
            }

            int maxEven = array.LastIndexOf(array.Where(m => m % 2 == 0).Min());

            Console.WriteLine(maxEven);
        }

        private static void OddMin(List<int> array)
        {
            if (!array.Any(x => x % 2 != 0))
            {
                Console.WriteLine("No matches");
                return;
            }

            int maxOdd = array.LastIndexOf(array.Where(m => m % 2 != 0).Min());

            Console.WriteLine(maxOdd);
        }

        private static void Even(List<int> array)
        {
            if (!array.Any(x => x % 2 == 0))
            {
                Console.WriteLine("No matches");
                return;
            }

            int maxEven = array.LastIndexOf(array.Where(m => m % 2 == 0).Max());

            Console.WriteLine(maxEven);
        }

        private static void Odd(List<int> array)
        {
            if (!array.Any(x => x % 2 != 0))
            {
                Console.WriteLine("No matches");
                return;
            }

            int maxOdd = array.LastIndexOf(array.Where(m => m % 2 != 0).Max());

            Console.WriteLine(maxOdd);
        }

        private static void Exchange(List<int> array, int index)
        {
            if (index >= array.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
                return;

            }



            else
            {
                var exchangedArray = array.Take(index + 1).ToList();

                array.RemoveRange(0, index + 1);
                array.AddRange(exchangedArray);



            }

        }
    }
}
