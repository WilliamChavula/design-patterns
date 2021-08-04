using System;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Abstract Factory Pattern Demo.***\n");

            // Making Wild Dog and Wild Tiger through WildAnimalFactory.
            // Here's the difference with the Factory Method Patter. 
            // We are not new-ing up an instance of a Factory. That is abstracted away
            IAnimalFactory animalFactory = FactoryProvider.GetAnimalFactory("wild");
            IDog dog = animalFactory.GetDog();
            ITiger tiger = animalFactory.GetTiger();
            dog.AboutMe();
            Console.WriteLine();
            tiger.AboutMe();
            Console.WriteLine();

            Console.WriteLine("*************************");
            Console.WriteLine();

            // Making a pet dog and pet tiger though the PetAnimalFactory now.
            animalFactory = FactoryProvider.GetAnimalFactory("pet");
            dog = animalFactory.GetDog();
            tiger = animalFactory.GetTiger();
            
            dog.AboutMe();
            Console.WriteLine();
            tiger.AboutMe();

            Console.ReadKey();
        }
    }
}
