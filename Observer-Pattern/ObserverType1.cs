using System;

namespace Observer_Pattern
{
    // ObserverType1
    public class ObserverType1 : IObserver
    {
        string nameOfObserver;
        public ObserverType1(string name)
        {
            this.nameOfObserver = name;
        }
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"{ nameOfObserver } has received an alert from { celebrity.Name }. Updated value is { celebrity.Flag }");
        }
    }
}