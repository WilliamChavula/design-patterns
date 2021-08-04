namespace Factory_Method_Pattern
{
    public class DogFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }
}