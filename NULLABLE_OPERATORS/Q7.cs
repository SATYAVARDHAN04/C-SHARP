// Given three nullable strings, find the first available value.

using System;
namespace NULLABLE_OPERATORS;

public class Q2
{
    public static void Main(string[] args)
    {
        string a = null;
        string b = null;
        string c = null;
        string s = a ?? b ?? c ?? "Default";
        Console.WriteLine(s);

    }
}