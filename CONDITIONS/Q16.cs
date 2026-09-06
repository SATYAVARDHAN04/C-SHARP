/*
Group January, February, and March into "Q1" .
Group April, May, and June into "Q2" .
Group July, August, and September into "Q3" .
Group October, November, and December into "Q4" .
*/
Console.Write("Enter a month=");
string month = Console.ReadLine();
string s = month switch
{
    "January" or "February" or "March" => "Q1",
    "April" or "May" or "June" => "Q2",
    "July" or "August" or "September" => "Q3",
    "October" or "November" or "December" => "Q4",
    _ => "Please enter a valid month"
};

Console.WriteLine(s);