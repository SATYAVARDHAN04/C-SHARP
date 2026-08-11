//Create a BankAccount class with a private PIN field. Provide a property or method that allows changing the PIN only when the old PIN is correctly supplied.

using System;

namespace ENCAPSULATION
{
    public class Q4
    {
        public static void Main(string[] args)
        {
            BankAccount b = new BankAccount(1341);

            Console.WriteLine("Changing PIN...");

            b.ChangePin(1341, 5678);

            b.ChangePin(1111, 9999);
        }
    }

    public class BankAccount
    {
        private int _pin;

        public BankAccount(int pin)
        {
            _pin = pin;
        }

        public void ChangePin(int oldPin, int newPin)
        {
            if (oldPin == _pin)
            {
                _pin = newPin;
                Console.WriteLine("PIN changed successfully.");
            }
            else
            {
                Console.WriteLine("Incorrect old PIN. PIN was not changed.");
            }
        }
    }
}