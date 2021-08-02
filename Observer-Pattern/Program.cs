using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Observer Pattern Demonstration. ***\n");
            
            IObserver myObserver1 = new ObserverType1("Roy");
            IObserver myObserver2 = new ObserverType1("Kevin");
            IObserver myObserver3 = new ObserverType1("Bose");
            IObserver myObserver4 = new ObserverType2("Jacklin");

            Console.WriteLine("Working with first celebrity now. \n");
            ICelebrity celebrity = new Celebrity("Celebrity-1");

            // Register the observers
            celebrity.Register(myObserver1);
            celebrity.Register(myObserver2);
            celebrity.Register(myObserver3);

            Console.WriteLine("Celebrity-1 is setting Flag = 5. \n");
            celebrity.Flag = 5;

            // Unregister Kevin. He won't receive any new notifications
            celebrity.Unregister(myObserver2);

            // celebrity changes Flag again
            Console.WriteLine("Celebrity-1 is setting Flag = 50. \n");
            celebrity.Flag = 50;

            // re-register Kevin. He will receive updates again.
            celebrity.Register(myObserver2);

            Console.WriteLine("Celebrity-1 is setting Flag = 100. \n");
            celebrity.Flag = 100;

            Console.WriteLine("Working with another celebrity now. \n");
            ICelebrity celebrity2 = new Celebrity("Celebrity-2");

            // Register observers
            celebrity2.Register(myObserver1);
            celebrity2.Register(myObserver4);

            Console.WriteLine("--Celebrity-2 is setting Flag value as 500. \n");
            celebrity2.Flag = 500;

            Console.Read();

        }
    }
}
