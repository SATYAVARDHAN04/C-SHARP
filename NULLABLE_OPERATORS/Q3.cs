// Create int? salary = null . Use ? to print 50000
using System;
namespace NULLABLE_OPERATORS;

public class Q2
{
    public static void Main(string[] args)
    {
        int? salary = null;
        int s = salary??50000;
        Console.WriteLine(s);
    }
}