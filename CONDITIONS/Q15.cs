/*
Convert:
90+ → A
80+ → B
70+ → C
60+ → D
Below 60 → F
into a switch expression.
*/

using System;
namespace CONDITIONS;

public class Q15
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number = ");
        int a = int.Parse(Console.ReadLine());
        string result = a switch
        {
            >90=>"A",
            >80=>"B",
            >70=>"C",
            >60=>"D",
            _ => "Fail"
        };
        Console.WriteLine(result);
    }
}
