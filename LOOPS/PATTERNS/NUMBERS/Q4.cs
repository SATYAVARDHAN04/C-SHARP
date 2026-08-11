//Perfect Number

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
            int s=0;

            for(int i = 1; i <a; i++)
            {
                if(a%i==0) s=s+i;
            }
            if(s==b) Console.WriteLine($"{b} is perfect number");
            else Console.WriteLine($"{b} is not an perfect number");

        }
    }
}