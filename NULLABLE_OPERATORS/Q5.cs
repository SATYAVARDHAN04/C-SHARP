// Create string department = null . Print "Not Assigned" when it is null.
using System;
namespace NULLABLE_OPERATORS;

public class Q2
{
    public static void Main(string[] args)
    {
        string department = null;
        string s = department??"Not Assigned";
        Console.WriteLine(s);
    }
}