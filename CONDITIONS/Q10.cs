/*
Create a student admission system.
Check:
Marks > 60?
↓
Age > 17?
↓
Admission eligible
*/

using System;
namespace CONDITIONS;

public class Q10
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of marks = ");
        int marks = int.Parse(Console.ReadLine());
        Console.Write("Enter the age = ");
        int age = int.Parse(Console.ReadLine());
        if (marks > 60)
        {
            if (age > 17)
            {
                Console.WriteLine("Admission eligible");
            }
        }
        else
        {
            Console.WriteLine("Admission not eligible");
        }
    }
}