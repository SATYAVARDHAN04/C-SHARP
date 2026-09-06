using System;

namespace BASICS;

public class Q3
{
    public static void Main(string[] args)
    {
        Console.Write("Enter age of the person=");
        int age = int.Parse(Console.ReadLine());
        if(age>18 && age<60)
        {
            Console.WriteLine("He is happy");
        }
        else
        {
            Console.WriteLine("He is not happy");
        }
    }
}