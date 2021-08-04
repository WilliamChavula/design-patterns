using System;

namespace Abstract_Factory_Pattern
{
    public class PetTiger : ITiger
    {
        public void AboutMe()
        {
            Console.WriteLine("Pet Tiger says: Halum. I play in an animal circus.");
        }
    }
}