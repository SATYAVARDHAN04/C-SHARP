using System;

namespace BASICS;

public class Q2
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number=");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number=");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Sum of the numbers {a} and {b} = {a+b}");
        Console.WriteLine($"Subtraction of the numbers {a} and {b} = {a-b}");
        Console.WriteLine($"Multiplication of the numbers {a} and {b} = {a*b}");
        Console.WriteLine($"Division of the numbers {a} and {b} = {a/b}");
        Console.WriteLine($"Modulus of the numbers {a} and {b} = {a%b}");
    }
}