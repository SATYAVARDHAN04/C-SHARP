//Create an abstract Animal class with an abstract MakeSound() method. Create Dog and Cat classes that provide their own implementations.

using System;
namespace ABSTRACTION
{
    public class Q1
    {
        public static void Main(string[] args)
        {
            Animal a = new Dog();
            a.MakeSound();
        }
    }
    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    public class Dog:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bow Bow Bow");
        }
    }

    public class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow Meow");
        }
    }
}