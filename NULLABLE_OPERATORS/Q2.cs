// Create string city = null . Use ? to assign "Hyderabad" as the fallback.
using System;
namespace NULLABLE_OPERATORS;

public class Q2
{
    public static void Main(string[] args)
    {
        string? city = null;
        string s = city??"Hyderabad";
        Console.WriteLine(s);
    }
}