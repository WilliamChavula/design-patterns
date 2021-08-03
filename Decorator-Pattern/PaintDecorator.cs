using System;

namespace Decorator_Pattern
{
    public class PaintDecorator : AbstractDecorator
    {
        public PaintDecorator(AbstractHome home) : base(home)
        {
            AdditionalPrice = 5_000;
        }

        public override void MakeHome()
        {
            base.MakeHome();
            PaintHome();
        }

        private void PaintHome()
        {
            Console.WriteLine($"-Painting done. Pay additional ${ AdditionalPrice } for it. ");
        }
    }
}