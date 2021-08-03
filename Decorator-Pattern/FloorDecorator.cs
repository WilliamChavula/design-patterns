using System;

namespace Decorator_Pattern
{
    public class FloorDecorator : AbstractDecorator
    {
        public FloorDecorator(AbstractHome home) : base(home)
        {
            AdditionalPrice = 2_500;
        }

        public override void MakeHome()
        {
            base.MakeHome();

            // Adding a floor on top of original house.
            AddFloor();
        }

        private void AddFloor()
        {
            Console.WriteLine($"-Additional Floor added. Pay additional ${ AdditionalPrice } for it.");
        }
    }
}