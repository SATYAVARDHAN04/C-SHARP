// Given three nullable email addresses, select the first available email.

using System;
namespace NULLABLE_OPERATORS;
public class Q2
{
    public static void Main(string[] args)
    {
        string a = "svardhan278@gmail.com";
        string b = null;
        string c = null;
        string s = a ?? b ?? c ?? "example@email.com";
        Console.WriteLine(s);

    }
}