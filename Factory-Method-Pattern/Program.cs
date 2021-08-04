using System;

namespace Factory_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Factory Method Pattern Demo. ***\n");

            // creating a TigerFactory
            AnimalFactory tigerFactory = new TigerFactory();

            // creating a tiger using the factory method
            IAnimal tiger = tigerFactory.CreateAnimal();
            tiger.AboutMe();

            // creating a DogFactory
            AnimalFactory dogFactory = new DogFactory();

            // creating a Dog using the factory method
            IAnimal dog = dogFactory.CreateAnimal();
            dog.AboutMe();

            Console.ReadKey();
        }
    }
}
