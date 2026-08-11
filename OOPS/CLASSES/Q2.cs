//Design a Counter class where every time a new instance is created, a static field tracks the total number of instances alive.
using System;

namespace OOPS.CLASSES
{
    public class Q2
    {
        public static void Main(string[] args)
        {
            Counter c1 = new Counter();
            Console.WriteLine(Counter.count);

            Counter c2 = new Counter();
            Console.WriteLine(Counter.count);

            Counter c3 = new Counter();
            Console.WriteLine(Counter.count);

            Counter c4 = new Counter();
            Console.WriteLine(Counter.count);
        }
    }

    public class Counter
    {
        public static int count = 0;

        public Counter()
        {
            count++;
        }
    }
}