//Create overloaded DisplayStudent() methods that display student information using only a name, name + age, and name + age + roll number.
using System;

namespace POLYMORPHISM
{
    public class Q1
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.DisplayStudent("Satya");
            s.DisplayStudent("Satya",21);
            s.DisplayStudent("Satya",21,17896);
        }
    }
    public class Student
    {
        public void DisplayStudent(String name)
        {
            Console.WriteLine($"Name = {name}");
        }

        public void DisplayStudent(String name,int age)
        {
            Console.WriteLine($"Name = {name} and age = {age}");
        }

        public void DisplayStudent(String name,int age,int roll)
        {
            Console.WriteLine($"Name = {name} and age = {age} and roll number = {roll}");
        }
    }
}

