using System;

namespace Abstract_Factory_Pattern
{
    public class WildDog : IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("Wild Dog says: I prefer to roam freely in the jungles. Bow-Wow.");
        }
    }
}