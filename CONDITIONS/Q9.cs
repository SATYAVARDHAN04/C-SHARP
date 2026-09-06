//Check whether a number is negative or divisible by 7
Console.Write("Enter a number = ");
int num = int.Parse(Console.ReadLine());
if(num<0 && num%7==0)
{
    Console.WriteLine("Number is negative and divisible by 7");
}

else if (num > 0)
{
    if(num%7==0)
    {
        Console.WriteLine("Number is greater than 0 and divisible by 7");
    }
    else
    {
        Console.WriteLine("Number is greater than 0 and is not divisible by 7");
    }
}