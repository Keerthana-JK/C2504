using System;

namespace BankAccount
{
    class Account 
    {
        string number;
        float balance;
        public Account(string _number)
        {
            number = _number;
            balance = 0;
        }
        public void Deposit(float amount)
        {
            if(amount>1000000)
            {
                Console.WriteLine("You cannot deposit more than 10 Lakhs");
                return;
            }
            balance += amount;
        }
        public void Withdraw(float amount)
        {
            if (balance - amount > balance)
            {
                Console.WriteLine("You cannot withdraw amount more than your balnce");
                    return;
            }
            balance -= amount;
        }
        public float GetBalance() 
        {
            return balance;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account keerthanaAcc = new Account("1001200230034");
            keerthanaAcc.Deposit(10000000);
            keerthanaAcc.Deposit(25000);
            keerthanaAcc.Withdraw(15000);
            Console.WriteLine($"Keerthana Acc balance: {keerthanaAcc.GetBalance()}");
        }
    }
}
