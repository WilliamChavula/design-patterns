using System;

namespace Singleton_Pattern
{
    public class SingletonUnSealed
    {
        private static readonly SingletonUnSealed Instance = new SingletonUnSealed();
        private static int TotalInstacesUnSealed;

        private SingletonUnSealed()
        {
            Console.WriteLine("--Private constructor is called.");
            TotalInstacesUnSealed++;
            Console.WriteLine($"-SingletonUnSealed instance is created. Number of instances: {TotalInstacesUnSealed}");
            Console.WriteLine("-Exit now from private constructor.");
        }

        public SingletonUnSealed GetInstance => Instance;


    public class NestedDerived : SingletonUnSealed
    {
    }
    }
}