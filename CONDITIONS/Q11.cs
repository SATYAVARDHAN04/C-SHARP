/*
Write a program using switch to print the day of the week:
1 → Monday
2 → Tuesday
3 → Wednesday
.
7 → Sunday
*/

using System;
namespace CONDITIONS;

public class Q11
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your choice=");
        int ch = int.Parse(Console.ReadLine());
        switch(ch)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;        
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;    
            default:
                Console.WriteLine("Please enter a valid choice only from 1 to 7");
                break;
        }
    }
}
