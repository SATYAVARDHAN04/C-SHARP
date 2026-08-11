//Create a MobilePhone class with a BatteryPercentage property. Ensure that the value always remains between 0 and 100.
using System;

namespace ENCAPSULATION
{
    public class Q3
    {
        public static void Main(string[] args)
        {
            MobilePhone m = new MobilePhone(69);

            Console.WriteLine(m.BatteryPercentage);

            m.BatteryPercentage = 85;

            Console.WriteLine(m.BatteryPercentage);

            m.BatteryPercentage = 150;

            Console.WriteLine(m.BatteryPercentage);
        }

        public class MobilePhone
        {
            private int _batteryPercentage;

            public MobilePhone(int batteryPercentage)
            {
                BatteryPercentage = batteryPercentage;
            }

            public int BatteryPercentage
            {
                get
                {
                    return _batteryPercentage;
                }

                set
                {
                    if (value >= 0 && value <= 100)
                    {
                        _batteryPercentage = value;
                    }
                }
            }
        }
    }
}