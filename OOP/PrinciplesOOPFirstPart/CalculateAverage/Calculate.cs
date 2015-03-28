namespace CalculateAverage
{
    using System;
    using Animals;
    using Animals.Models;
    using System.Collections.Generic;

    class Calculate
    {
        static void Main()
        {
            Kitten[] kittenArr = new Kitten[] {new Kitten("Sara", 5), new Kitten("Tamara", 7), new Kitten("Tony", 8) };
            Console.Write("Kittens average age: ");
            Console.WriteLine(Animal.AverageAge(kittenArr));

            Dog[] dogArr = new Dog[] { new Dog("Ralf", 3), new Dog("Sharo", 5), new Dog("Ares", 8) };
            Console.Write("Dogs average age: ");
            Console.WriteLine(Animal.AverageAge(dogArr));

            List<Animal> animalList = new List<Animal>();
            animalList.AddRange(kittenArr);
            animalList.AddRange(dogArr);

            Console.Write("All animals average age: ");
            Console.WriteLine(Animal.AverageAge(animalList));
        }
    }
}