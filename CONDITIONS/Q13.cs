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
        switch (ch)
        {
            case 'a' or 'A':
                Console.WriteLine("Vowel");
                break;
            case 'e' or 'E':
                Console.WriteLine("Vowel");
                break;
            case 'i' or 'I':
                Console.WriteLine("Vowel");
                break;
            case 'o' or 'O':
                Console.WriteLine("Vowel");
                break;
            case 'u' or 'U':
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Consonant");
                break;                    
        }
    }
}
