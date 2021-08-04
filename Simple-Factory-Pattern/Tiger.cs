using System;

namespace Simple_Factory_Pattern
{
    public class Tiger : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("The tiger says: Halum. I prefer hunting.");
        }
    }
}