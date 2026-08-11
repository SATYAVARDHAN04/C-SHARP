//Prime Number

using System;
namespace NUMBERS
{
    public class Q2
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number=");
            int a = Convert.ToInt32(Console.ReadLine());
            int c=0;
            for(int i = 1; i <=a/2; i++)
            {
                if(a%i==0) c=c+1;
            }
            if(c==1) Console.WriteLine($"{a} is prime number");
            else Console.WriteLine($"{a} is not an prime number");

        }
    }
}