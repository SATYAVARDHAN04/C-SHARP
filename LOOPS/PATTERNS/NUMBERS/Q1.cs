//Armstrong

using System;
namespace NUMBERS
{
    public class Q1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number=");
            int a = Convert.ToInt32(Console.ReadLine());
            int len = (int)Math.Log10(a)+1;
            int b = a;
            int s=0;
            for(int i = 0; i < len; i++)
            {
                int m = a%10;
                s = s+(int)Math.Pow(m,len);
                a = a/10;
            }
            if(s==b) Console.WriteLine($"{b} is Armstrong number");
            else Console.WriteLine($"{b} is not an Armstrong number");

        }
    }
}