//Create an abstract Report class with abstract methods Generate() and Export(). Implement different report formats.

using System;
namespace ABSTRACTION
{  
    public class Q3
    {
        public static void Main(string[] args)
        {
            Fan f = new Fan();
            f.TurnOn();
        }
    }
    public abstract class Report
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