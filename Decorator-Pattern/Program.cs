using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Decorator Pattern demo ***");

            #region Scenario-1
            Console.WriteLine("\n**Scenario-1: ");
            Console.WriteLine("**Building home. Adding floor and then painting it.**\n\n");

            AbstractHome home = new ConcreteHome();
            Console.WriteLine("Current bill breakups as follows:");
            home.MakeHome();

            // Apply a decorator
            // Adding a floor
            home = new FloorDecorator(home);
            Console.WriteLine("\nFloor added. Current bill breakups are as follows:");
            home.MakeHome();

            // Working on top of the previous decorator
            // Painting the home
            home = new PaintDecorator(home);
            Console.WriteLine("\nPaint applied. Current bill breakups are as follows:");
            home.MakeHome();
            #endregion
        }
    }
}
