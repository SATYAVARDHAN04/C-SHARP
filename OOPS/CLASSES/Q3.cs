//Write a Bank class with a private nested class TransactionLedger that can access the private outer fields of the Bank instance directly.

using System;

namespace OOPS.CLASSES
{
    public class Q3
    {
        public static void Main(string[] args)
        {
            Bank b1 = new Bank("ACC101", "Saraswati", 50000);
            b1.ShowTransactionDetails();
        }
    }

    public class Bank
    {
        private string accno;
        private string holder;
        private int amt;

        public Bank(string accno, string holder, int amt)
        {
            this.accno = accno;
            this.holder = holder;
            this.amt = amt;
        }

        public void ShowTransactionDetails()
        {
            TransactionLedger ledger = new TransactionLedger(this);

            ledger.DisplayDetails();
        }

        private class TransactionLedger
        {
            private Bank bank;

            public TransactionLedger(Bank bank)
            {
                this.bank = bank;
            }

            public void DisplayDetails()
            {
                Console.WriteLine("Account Number: " + bank.accno);
                Console.WriteLine("Account Holder: " + bank.holder);
                Console.WriteLine("Amount: " + bank.amt);
            }
        }
    }
}