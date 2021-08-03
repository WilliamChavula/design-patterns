using System;

namespace Decorator_Pattern
{
    public class ConcreteHome : AbstractHome
    {
        public ConcreteHome()
        {
            AdditionalPrice = 0;
        }

        public override void MakeHome()
        {
            Console.WriteLine($"Original House is constructed. Price for this is $10000.");
        }
    }
}