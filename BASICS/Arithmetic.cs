using System;

namespace BASICS
{
    public class Arithmetic
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first number=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum of {a} and {b} = {a+b}");
            Console.WriteLine($"Subtraction of {a} and {b} = {a-b}");
            Console.WriteLine($"Multiplication of {a} and {b} = {a*b}");
            Console.WriteLine($"Division of {a} and {b} = {a/b}");
            Console.WriteLine($"Remainder of {a} and {b} = {a%b}");

        }
    }
}