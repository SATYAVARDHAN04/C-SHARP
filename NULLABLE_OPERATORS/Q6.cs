//Read a nullable discount and provide 10 if it is null.
using System;
namespace NULLABLE_OPERATORS;

public class Q2
{
    public static void Main(string[] args)
    {
        int? discount = null;
        int s = discount??10;
        Console.WriteLine(s);
    }
}