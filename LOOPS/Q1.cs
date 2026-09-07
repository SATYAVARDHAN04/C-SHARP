//Print numbers from 1 to 10
using System;
namespace LOOPS;

public class Q1 {
    public static void Main(string[] args)
    {
        int i;
        for (i = 0; i < 10; i++)
        {
            Console.Write($"{i+1}, ");
        }
    }
}