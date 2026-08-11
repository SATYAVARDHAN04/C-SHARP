/*
$ * * *
* $ * *
* * $ *
* * * $
*/

using System;
namespace LOOPS.PATTERNS.STARS
{
    public class Q
    {
        public static void Main(string[] args)
        {
            int i=0,j=0;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if(i==j) Console.Write($"$ ");
                    else Console.Write($"* ");
                }
                Console.WriteLine();
            }
        }
    }
}
