//Check whether a number is divisible by 2. If yes, check whether it is divisible by 4.

using System;
namespace CONDITIONS;

public class Q7
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number = ");
        int a = int.Parse(Console.ReadLine());
        if(a%2==0)
        {
            if(a%4==0)
            {
                Console.WriteLine("Number is divisible by both 2 and 4");
            }
            else
            {
                Console.WriteLine("Number is divisible only 2");
            }
        }
        else
        {
            Console.WriteLine("Number is not divisible by 2");
        }
    }
}