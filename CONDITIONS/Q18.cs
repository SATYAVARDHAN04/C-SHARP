/*
Create:
enum Day
{
Monday,
Tuesday,
Wednesday,
Thursday,
Friday,
Saturday,
Sunday
}
Use switch to print the day type.
*/
using System;
namespace CONDITIONS;

enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public class Q18
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a day=");
        string input = Console.ReadLine();
        Day day = Enum.Parse<Day>(input);
        switch (day)
        {
            case Day.Monday:
                Console.WriteLine("Today is Monday");
                break;
            case Day.Tuesday:
                Console.WriteLine("Today is Tuesday");
                break;
            case Day.Wednesday:
                Console.WriteLine("Today is Wednesday");
                break;
            case Day.Thursday:
                Console.WriteLine("Today is Thursday");
                break;
            case Day.Friday:
                Console.WriteLine("Today is Friday");
                break;
            case Day.Saturday:
                Console.WriteLine("Today is Saturday");
                break;
            case Day.Sunday:
                Console.WriteLine("Today is Sunday");
                break;                        
        }

    }
}