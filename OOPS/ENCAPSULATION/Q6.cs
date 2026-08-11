//Create a ShoppingCart class containing a private collection of products. Provide methods to add and remove products without exposing the collection directly.

using System;
using System.Collections.Generic;

namespace ENCAPSULATION
{
    public class Q6
    {
        public static void Main(string[] args)
        {
            ShoppingCart ss = new ShoppingCart();

            ss.Add("Shirt");
            ss.Add("Pant");

            ss.Remove("Shirt");
            ss.Remove("Pen");
        }
    }

    public class ShoppingCart
    {
        private List<string> _products = new List<string>();

        public void Add(string prod)
        {
            _products.Add(prod);
            Console.WriteLine($"{prod} added successfully");
        }

        public void Remove(string prod)
        {
            if (_products.Contains(prod))
            {
                _products.Remove(prod);
                Console.WriteLine($"{prod} removed successfully");
            }
            else
            {
                Console.WriteLine($"{prod} could not be found");
            }
        }
    }
}