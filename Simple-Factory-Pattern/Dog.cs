using System;

namespace Simple_Factory_Pattern
{
    public class Dog : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("The dog says: Bow-Wow. I prefer barking");
        }
    }
}