using System;

namespace Strategy_Pattern
{
    /// <summary>
    /// Abstract Behavior
    /// </summary>
    public abstract class VehicleBehavior
    {
        public abstract void AboutMe(string vehicle);
    }

    /// <summary>
    /// Floating capability
    /// </summary>
    public class FloatingBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine($"My { vehicle } can float now.");
        }
    }

    /// <summary>
    /// Flying capability
    /// </summary>
    public class FlyBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine($"My { vehicle } can fly now.");
        }
    }

    ///<summary>
    ///Initial behavior. Cannot do anything special.
    ///</summary>
    public class InitialBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine($"My { vehicle } is just born. It cannot do anything special.");
        }
    }

    ///<summary>
    /// Context class Vehicle
    /// </summary>
    public class  Vehicle
    {
        VehicleBehavior behavior;
        string vehicleType;

        public Vehicle (string vehicleType)
        {
            this.vehicleType = vehicleType;
            // Setting the initial behavior
            this.behavior = new InitialBehavior();
        }

        public void SetVehicleBehavior(VehicleBehavior behavior)
        {
            this.behavior = behavior;
        }

        public void DisplayAboutMe()
        {
            behavior.AboutMe(vehicleType);
        }
    }
}