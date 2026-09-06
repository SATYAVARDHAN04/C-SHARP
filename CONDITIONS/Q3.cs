//Check whether a number is greater than 100 or not.
using System;
namespace CONDITIONS;

public class Q2
{
    public static void Main (string[] args)
    {
        Console.Write("Enter a number=");
        int num = int.Parse(Console.ReadLine());
        if(num>100)
        {
            Console.WriteLine("Greater than 100");
        }
        else
        {
            Console.WriteLine("Less than 100");
        }

    }
}