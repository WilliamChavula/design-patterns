using System.Collections.Generic;

namespace Observer_Pattern
{
    public class Celebrity : ICelebrity
    {
        List<IObserver> observerList = new List<IObserver>();
        private string name;
        public string Name => name;

        private int flag;
        public int Flag
        {
            get 
            { 
                return flag; 
            }
            set 
            { 
                flag = value; 
                NotifyRegisteredUsers();
            }
        }
        
        
        public Celebrity(string name)
        {
            this.name = name;
        }
        public void NotifyRegisteredUsers()
        {
            foreach (IObserver observer in observerList)
            {
                observer.Update(this);
            }
        }

        public void Register(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observerList.Remove(observer);
        }
    }
}