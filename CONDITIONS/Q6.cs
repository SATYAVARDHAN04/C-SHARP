// Check whether a number is positive. If yes, check whether it is even or odd.
using System;
namespace CONDITIONS;

public class Q6
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number = ");
        int a = int.Parse(Console.ReadLine());
        if(a>0)
        {
            if(a%2==0)
            {
                Console.WriteLine("Number is positive and even");
            }
            else
            {
                Console.WriteLine("Number is positive and odd");
            }
        }
        else
        {
            Console.WriteLine("Number is negative");
        }
    }
}