namespace Decorator_Pattern
{
    public abstract class AbstractHome
    {
        public double AdditionalPrice { get; set; }
        public abstract void MakeHome();
    }
}