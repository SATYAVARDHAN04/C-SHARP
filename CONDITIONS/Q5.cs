/*
Create a grading system:
90–100 → A
80–89 → B
70–79 → C
60–69 → D
Below 60 → F
*/

using System;

namespace CONDITIONS;
public class Q5
{
    public static void Main (string[] args)
    {
        Console.Write("Enter the number of marks=");
        int marks = int.Parse(Console.ReadLine());
        if(marks>=90 && marks <= 100)
        {
            Console.WriteLine("A");
        }
        else if(marks>=80 && marks <= 89)
        {
            Console.WriteLine("B");
        }
        else if(marks>=70 && marks <= 79)
        {
            Console.WriteLine("C");
        }
        else if(marks>=60 && marks <= 69)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}