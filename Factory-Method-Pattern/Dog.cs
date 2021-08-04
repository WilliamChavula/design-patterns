using System;

namespace Factory_Method_Pattern
{
    public class Dog : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("The dog says: Bow-wow. I prefer barking.");
        }
    }
}