//Create an abstract Appliance class with an abstract TurnOn() method. Create Fan, WashingMachine, and Television classes.

using System;
namespace ABSTRACTION
{
    public class Q2
    {
        public static void Main(string[] args)
        {
            Fan f = new Fan();
            f.TurnOn();
        }
    }
    public abstract class Appliance
    {
        public abstract void TurnOn();
    }

    public class Fan:Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Turns around");
        }
    }

    public class WashingMachine:Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Spins");
        }
    }
}