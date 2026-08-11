//Create a Product class where ProductId can only be assigned once and cannot be changed afterward.
using System;

namespace ENCAPSULATION
{
    public class Q5
    {
        public static void Main(string[] args)
        {
            Product p = new Product(145);
            Console.WriteLine(p.PID);
        }
    }

    public class Product
    {
        public int PID { get; }

        public Product(int pid)
        {
            PID = pid;
        }
    }
}