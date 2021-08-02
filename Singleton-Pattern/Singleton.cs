using System;

namespace Singleton_Pattern
{
    public sealed class Singleton {

        #region Singleton implementation using static constructor
        private static readonly Singleton Instance;
        private static int TotalInstaces;

        /*
        * Private constructor is used to prevent
        * creation of instances with the 'new' keywork
        * outside this class.
        */

        private Singleton()
        {
            Console.WriteLine("--Private constructor is called.");
            Console.WriteLine("--Exit now from private constructor.");
        }

        /*
        * S static constructor is used for the following purposes:
        * 1. To initialize any static data
        * 2. To perform a specific action only once
        *
        * The static constructor will be called automatically before:
        * i. You create the first instance; or
        * ii. You refer to any static members in your code.
        *
        */

        // Here is the static constructor
        static Singleton()
        {
            // printing some messages before you create the instance
            Console.WriteLine("-Static constructor is called");
            Instance = new Singleton();
            TotalInstaces++;
            Console.WriteLine($"-Singleton instance is created. Number of instances: { TotalInstaces }");
            Console.WriteLine("-Exit from static constructor.");
        }

        public static Singleton GetInstance => Instance;

        #endregion
    }
}