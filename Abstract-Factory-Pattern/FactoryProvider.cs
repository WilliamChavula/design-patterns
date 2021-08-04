using System;

namespace Abstract_Factory_Pattern
{
    public class FactoryProvider
    {
        public static IAnimalFactory GetAnimalFactory(string factoryType)
        {
            if (factoryType.Contains("wild"))
            {
                // Returning a WildAnimalFactory
                return new WildAnimalFactory();
            } 
            else if (factoryType.Contains("pet"))
            {
                // Returning a PetAnimalFactory
                return new PetAnimalFactory();
            }
            else 
            {
                throw new ArgumentException("You need to pass either wild or pet as argument.");
            }
        }
    }
}