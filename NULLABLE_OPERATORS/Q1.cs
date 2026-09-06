// Create string name = "John" . Use ? to provide "Unknown" as the fallback value.
using System;
namespace NULLABLE_OPERATORS;

public class Q1
{
    public static void Main(string[] args)
    {
        string name = "John";
        string s = name??"Unknown";
        Console.WriteLine(s);
    }
}