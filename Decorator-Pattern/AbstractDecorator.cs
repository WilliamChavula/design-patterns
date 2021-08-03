namespace Decorator_Pattern
{
    public abstract class AbstractDecorator : AbstractHome
    {
        protected AbstractHome home;

        protected AbstractDecorator(AbstractHome home)
        {
            this.home = home;
            this.AdditionalPrice = 0;
        }

        public override void MakeHome()
        {
            home.MakeHome();
        }
    }
}