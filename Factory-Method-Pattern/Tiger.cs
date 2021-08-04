using System;

namespace Factory_Method_Pattern
{
    public class Tiger : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("The tiger says: Halum. I prefer hunting.");
        }
    }
}