using System;

namespace Abstract_Factory_Pattern
{
    public class WildTiger : ITiger
    {
        public void AboutMe()
        {
            Console.WriteLine("Wild Tiger says: I prefer hunting in jungles. Halum.");
        }
    }
}