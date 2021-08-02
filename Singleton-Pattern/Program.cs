using System;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Singleton Pattern Demonstation.***\n");
            Console.WriteLine("Trying to get a Singleton Instance, called firstInstance.");
            Singleton firstInstance = Singleton.GetInstance;
            Console.WriteLine("Trying to get another Singleton instance, called secondInstance.");
            Singleton secondInstance = Singleton.GetInstance;
            if (firstInstance.Equals(secondInstance))
            {
                Console.WriteLine("The firstInstance and secondInstance are the same");
            } else
            {
                Console.WriteLine("Different instances exist.");
            }

            Console.WriteLine("***Singleton Pattern Demonstation.***\n");
            Console.WriteLine("Trying to get a SingletonUnSealed Instance, called firstInstance.");
            SingletonUnSealed.NestedDerived nestedFirstInstance = new SingletonUnSealed.NestedDerived();
            Console.WriteLine("Trying to get another Singleton instance, called secondInstance.");
            SingletonUnSealed.NestedDerived nestedSecondInstance = new SingletonUnSealed.NestedDerived();
            if (firstInstance.Equals(secondInstance))
            {
                Console.WriteLine("The nestedFirstInstance and nestedSecondInstance are the same");
            } else
            {
                Console.WriteLine("Different instances exist.");
            }
            Console.Read();
        }
    }
}
