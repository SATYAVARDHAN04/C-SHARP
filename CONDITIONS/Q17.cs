/*
Take a character representing a direction:
N → North
S → South
E → East
W → West
*/

Console.Write("Enter a charcter direction=");
char ch = (char)Console.Read();
string s = ch switch
{
    'E' or 'e' => "EAST",
    'w' or 'W' => "WEST",
    'N' or 'n' => "North",
    'S' or 's' => "South",
};
Console.WriteLine(s);