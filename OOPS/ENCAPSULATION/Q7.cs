//Create an Employee class that encapsulates employee information and salary. Provide controlled methods for salary increments, deductions, and bonus calculations.
using System;

namespace ENCAPSULATION
{
    public class Q7
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the name of employee: ");
            string name = Console.ReadLine();

            Console.Write("Enter the id of employee: ");
            string id = Console.ReadLine();

            Console.Write("Enter the salary of employee: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Employee e = new Employee(name, id, salary);

            Console.Write("Enter the percentage to increment salary: ");
            double increment = Convert.ToDouble(Console.ReadLine());

            e.IncrementSalary(increment);

            Console.WriteLine($"Salary after increment: {e.GetSalary()}");

            Console.Write("Enter the percentage to deduct from salary: ");
            double deduction = Convert.ToDouble(Console.ReadLine());

            e.DeductSalary(deduction);

            Console.WriteLine($"Salary after deduction: {e.GetSalary()}");

            Console.Write("Enter the percentage of bonus: ");
            double bonusPercentage = Convert.ToDouble(Console.ReadLine());

            double bonus = e.CalculateBonus(bonusPercentage);

            Console.WriteLine($"Bonus amount: {bonus}");
        }
    }

    public class Employee
    {
        public string Name { get; }
        public string Id { get; }

        private double _salary;

        public Employee(string name, string id, double salary)
        {
            Name = name;
            Id = id;
            _salary = salary;
        }

        public void IncrementSalary(double percentage)
        {
            double increment = (_salary * percentage) / 100;
            _salary = _salary + increment;
        }

        public void DeductSalary(double percentage)
        {
            double deduction = (_salary * percentage) / 100;
            _salary = _salary - deduction;
        }

        public double CalculateBonus(double percentage)
        {
            double bonus = (_salary * percentage) / 100;
            return bonus;
        }

        public double GetSalary()
        {
            return _salary;
        }
    }
}