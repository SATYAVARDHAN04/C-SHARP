/*
Use switch to identify vowels:
a → Vowel
e → Vowel
i → Vowel
o → Vowel
u → Vowel
*/

using System;
namespace CONDITIONS;

public class Q12
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your choice=");
        char ch = (char)Console.Read();
        string msg = ch switch
        {
            'a' or 'A'=>"Vowel",
            'e' or 'E'=>"Vowel",
            'i' or 'I'=>"Vowel",
            'o' or 'O'=>"Vowel",
            'u' or 'U'=>"Vowel",
            _ =>"Consonant"
        };
        Console.WriteLine(msg);
    }
}
