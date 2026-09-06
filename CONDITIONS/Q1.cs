//Write a program to check whether a student has passed ( marks > 40 ).
using System;

namespace CONDITIONS;

public class Q1
{
    public static void Main (string[] args)
    {
        Console.Write("Enter the number of marks=");
        int marks = int.Parse(Console.ReadLine());
        if(marks>40)
        {
            Console.WriteLine("Exam Passed");
        }
        else
        {
            Console.WriteLine("Exam Failed");
        }

    }
}