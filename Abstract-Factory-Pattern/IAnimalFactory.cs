namespace Abstract_Factory_Pattern
{
    public interface IAnimalFactory
    {
         IDog GetDog();
         ITiger GetTiger();
    }
}