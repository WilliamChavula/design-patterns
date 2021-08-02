namespace Observer_Pattern
{
    public interface ICelebrity
    {
         //Name of Subject
         string Name { get; }
         int Flag {get; set; }

         // To Register
         void Register(IObserver observer);

         // To Unregister
         void Unregister(IObserver observer);

         // To Notify registered users
         void NotifyRegisteredUsers();
    }
}