using System;

namespace BankAccount
{
    class Account 
    {
        public string number;
        private float balance;

        public float Balance
        {
            private set {
                if (value < 0 )
                {
                    Console.WriteLine("You cannot deposit a negative amount");
                }
                if (value > 5000000)
                {
                    Console.WriteLine("You cannot deposit amount more than 5000000");
                }
                balance = value; 
            }
            get { return balance; }
        }
        public Account(string _number)
        {
            number = _number;
            balance = 0;
        }
        public void Deposit(float amount)
        {
            //if(amount>1000000)
            //{
            //    Console.WriteLine("You cannot deposit more than 10 Lakhs");
            //    return;
            //}
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
            keerthanaAcc.Deposit(7000000);
            keerthanaAcc.Deposit(25000);
            keerthanaAcc.Withdraw(15000);
            //keerthanaAcc.Balance = 45; //can be changed from outside (if balance is public)
                                        //cant be changed here, if made private to class
            Console.WriteLine($"Keerthana Acc balance: {keerthanaAcc.Balance}");
        }
    }
}
