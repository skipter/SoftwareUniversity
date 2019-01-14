
namespace CatObject.Core
{
    using CatObject.Models.Cat;
    using CatObject.Models.Dog;

    using System;
    using System.Reflection;

    public class Engine
    {
        public void Run()
        {

            string inputData = Console.ReadLine();

            while (inputData != "end")
            {
                string[] tokens = inputData.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string animalType = tokens[0].ToLower();
                string name = tokens[1];
                int age = int.Parse(tokens[2]);
                string activity = tokens[3];

                if (animalType == "dog")
                {
                    Dog dog = new Dog(name, age);
                    Console.WriteLine($"Dog name is {dog.Name} and his age is {dog.Age}. His best activity is {activity}");
                    Type type = dog.GetType();
                    MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static);

                    foreach (var method in methods)
                    {
                        Console.WriteLine(method.Name);
                    }

                }
                else
                {
                    Cat cat = new Cat(name, age);
                }

                inputData = Console.ReadLine();
            }
        }
    }
}
