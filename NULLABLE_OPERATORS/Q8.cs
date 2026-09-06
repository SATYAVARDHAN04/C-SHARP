//Given three nullable integers, print the first non-null number

using System;
namespace NULLABLE_OPERATORS;

public class Q2
{
    public static void Main(string[] args)
    {
        int? a = null;
        int? b = null;
        int? c = null;
        int s = a ?? b ?? c ?? 25;
        Console.WriteLine(s);

    }
}