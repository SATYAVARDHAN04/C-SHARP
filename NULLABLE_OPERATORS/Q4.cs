//Create string email = null . Print "No Email" if it is null.
using System;
namespace NULLABLE_OPERATORS;

public class Q2
{
    public static void Main(string[] args)
    {
        string email = null;
        string s = email??"No Email";
        Console.WriteLine(s);
    }
}