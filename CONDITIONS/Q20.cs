/*
Use when to classify age as:
text Code
< 13 → Child
13–19 → Teenager
20–59 → Adult
60+ → Senior
*/

using System;
namespace CONDITIONS;

public class Q20
{
    public static void Main (string[] args)
    {
        Console.Write("Enter your age=");
        int age = int.Parse(Console.ReadLine());
        switch(age)
        {
            case int n when n>=60:
                Console.WriteLine("Senior");
                break;
            case int n when n>=20 && n<=59:
                Console.WriteLine("Adult");
                break;
            case int n when n>=13 && n<=19:
                Console.WriteLine("Teenager");
                break;
            case int n when n>=1 && n<13:
                Console.WriteLine("Child");
                break;
            default:
                Console.WriteLine("Please enter a valid age");
                break;
        }
    }
}