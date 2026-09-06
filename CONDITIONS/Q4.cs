// Check whether a number is between 1–10, 11–20, and 21–30 using separate if statements.

Console.Write("Enter a number = ");
int a = int.Parse(Console.ReadLine());
if(a>=1 && a<=10)
{
    Console.WriteLine("It is in between 1 and 10");
}
else if(a>=11 && a<=20)
{
    Console.WriteLine("It is in between 11 and 20");
}

else if(a>=21 && a<=30)
{
    Console.WriteLine("It is in between 21 and 30");
}

else
{
    Console.WriteLine("Number is greater than 30");
}