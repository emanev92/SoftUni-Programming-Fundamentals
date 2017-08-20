using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Animals
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Inteligence { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Cruelty { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();


            while (input != "I'm your Huckleberry")
            {
                var tokens = input.Split(' ');

                if (tokens.Length > 2)
                {
                    var type = tokens[0];
                    var name = tokens[1];
                    var age = int.Parse(tokens[2]);
                    var parameter = int.Parse(tokens[3]);


                    switch (type)
                    {
                        case "Dog":
                            var newDog = new Dog();
                            newDog.Name = name;
                            newDog.Age = age;
                            newDog.NumberOfLegs = parameter;

                            dogs.Add(newDog.Name, newDog);
                            break;
                        case "Cat":
                            var newCat = new Cat();
                            newCat.Name = name;
                            newCat.Age = age;
                            newCat.Inteligence = parameter;

                            cats.Add(newCat.Name, newCat);
                            break;
                        case "Snake":
                            var newSnake = new Snake();
                            newSnake.Name = name;
                            newSnake.Age = age;
                            newSnake.Cruelty = parameter;

                            snakes.Add(newSnake.Name, newSnake);
                            break;

                    }

                }

                else
                {
                    var animalName = tokens[1];

                    if (dogs.ContainsKey(animalName))
                    {
                        dogs[animalName].ProduceSound();
                    }

                    else if (cats.ContainsKey(animalName))
                    {
                        cats[animalName].ProduceSound();
                    }

                    else
                    {
                        snakes[animalName].ProduceSound();
                    }
                }



                input = Console.ReadLine();
            }

            foreach (var dog in dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs} ");
            }
            foreach (var cat in cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.Inteligence} ");
            }
            foreach (var snake in snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.Cruelty} ");
            }
        }
    }
}
