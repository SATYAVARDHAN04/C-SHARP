/*
Create a complete calculator using switch that accepts:
First number
Operator
Second number
and performs the selected operation.
*/

using System;
namespace CONDITIONS;

public class Q12
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the operator = ");
        char ch = (char)Console.Read();
        int result = ch switch
        {
            '+'=>a+b,
            '-'=>a-b,
            '*'=>a*b,
            '/'=>a/b,
            '%'=>a%b,
            _ => 0
        };
        if(result==0) Console.WriteLine("Please enter a valid operator");
        else Console.WriteLine(result);
    }
}
