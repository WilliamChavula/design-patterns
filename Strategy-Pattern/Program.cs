using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Strategy Pattern Demo***\n\n");
            Vehicle context = new Vehicle("Aeroplane");
            context.DisplayAboutMe();
            Console.WriteLine("Setting flying capability to vehicle");
            context.SetVehicleBehavior(new FlyBehavior());
            context.DisplayAboutMe();

            Console.WriteLine("Changing the vehicle behavior again.");
            context.SetVehicleBehavior(new FloatingBehavior());
            context.DisplayAboutMe();

            Console.Read();
        }
    }
}
