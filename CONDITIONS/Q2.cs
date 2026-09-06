// Check whether a person is an adult or a minor.
using System;
namespace CONDITIONS;

public class Q2
{
    public static void Main (string[] args)
    {
        Console.Write("Enter the age=");
        int age = int.Parse(Console.ReadLine());
        if(age>=18)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Minor");
        }

    }
}