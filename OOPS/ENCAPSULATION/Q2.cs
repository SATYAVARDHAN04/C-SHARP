//Create a Student class with private fields for name, age, and rollNumber. Provide public properties to get and set these values. Create a program to display student details.

using System;

namespace ENCAPSULATION
{
    public class Q1
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student("Satya", 20, 101);
            Console.WriteLine($"Name: {s1.Name}, Age: {s1.Age}, Roll: {s1.RollNumber}");
            s1.Age = 21;
            Console.WriteLine($"Updated Age: {s1.Age}");
        }
    }

    public class Student
    {
        private string name;
        private int age;
        private int rollnumber;

        // Constructor
        public Student(string name, int age, int rollnumber)
        {
            this.name = name;
            this.age = age;
            this.rollnumber = rollnumber;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set 
            { 
                if (value > 0)  
                    age = value; 
            }
        }

        public int RollNumber
        {
            get { return rollnumber; }
            set { rollnumber = value; }
        }
    }
}
