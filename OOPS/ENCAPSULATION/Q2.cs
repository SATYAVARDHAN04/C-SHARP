//Create an Employee class with private fields employeeId, name, and salary. Use properties to access them. Create an employee object and display its information.

using System;

namespace ENCAPSULATION
{
    public class Q2
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(1796, "Satya", 10100);
            
            // ✅ Properties are PascalCase - use them!
            Console.WriteLine($"Name: {e1.Name}, EmpId: {e1.EmpId}, Salary: {e1.Salary}");
            
            // ✅ Update using property
            e1.Salary = 12100;
            Console.WriteLine($"Updated Salary: {e1.Salary}");
        }
    }

    public class Employee
    {
        // ✅ Private fields with underscore prefix
        private int _empId;
        private string _name;
        private int _salary;

        // Constructor - assigns to private fields note that public and private field should not have same name
        public Employee(int empId, string name, int salary)
        {
            _name = name;
            _empId = empId;
            _salary = salary;
        }
        
        // ✅ Public properties with PascalCase
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int EmpId
        {
            get { return _empId; }
            set { _empId = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
    }
}