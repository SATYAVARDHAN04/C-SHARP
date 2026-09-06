//Check whether salary is between ₹30,000 and ₹80,000.
using System;

namespace CONDITIONS;
public class Q8
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the salary of the employee=");
        int sal = int.Parse(Console.ReadLine());
        if(sal>30000 && sal<80000)
        {
            Console.WriteLine("Salary is in between the given range");
        }
        else
        {
            Console.WriteLine("Salaray is not in the range");
        }
    }
}