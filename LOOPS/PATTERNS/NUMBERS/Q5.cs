//Automorphic Number

using System;
namespace NUMBERS
{
    public class Q4
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number=");
            int a = Convert.ToInt32(Console.ReadLine());
            int b=a;
            int s=a*a;
            int l = (int)Math.Log10(a)+1;
            int p=s%(int)Math.Pow(10,l);
            if(p==b) Console.WriteLine($"{b} is Automorphic number");
            else Console.WriteLine($"{b} is not an Automorphic number");

        }
    }
}