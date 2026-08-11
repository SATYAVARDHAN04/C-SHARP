//Palindrome Number

using System;
namespace NUMBERS
{
    public class Q3
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number=");
            int a = Convert.ToInt32(Console.ReadLine());
            int l = (int)Math.Log10(a)+1;
            int b=a;
            int s=0;

            for(int i = 0; i <l; i++)
            {
                int n = a%10;
                s=s*10+n;
                a = a/10;
            }
            if(s==b) Console.WriteLine($"{b} is palindrome number");
            else Console.WriteLine($"{b} is not an palindrome number");

        }
    }
}