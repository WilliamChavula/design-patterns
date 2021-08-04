using System;

namespace Abstract_Factory_Pattern
{
    public class PetDog : IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("Pet Dog says: Bow-Wow. I prefer to stay at home.");
        }
    }
}