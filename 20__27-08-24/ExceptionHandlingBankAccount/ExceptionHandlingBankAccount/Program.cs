
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingBankAccount
{
    class AccountDetails
    {
        private long _accountNumber;

        public long AccountNumber
        {
            get { return _accountNumber; }
            set 
            {
                if (value < 111_111_1111 || value > 999_999_9999)
                {
                    throw new Exception("Invalid account number");
                }
                _accountNumber = value; 
            }
        }

        public string Name { get; set; }
        public double Balance
        {
            get => _balance;
            set 
            {
            }
        }
    }

    class Bank
    {
        public enum BankFunctions
        {
            Deposit=1, ViewBalance, Transaction, CreateAccount
        }
        private List<AccountDetails> _accounts;
        public Bank()
        {
            _accounts = new List<AccountDetails>();
        }
        public void Deposit()
        {

        }
        public void ViewBalance()
        {

        }
        public void Transaction()
        {

        }
        public void CreateAccount()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. View Balance");
            Console.WriteLine("3. Transaction");
            Console.WriteLine("4. Create Account");
            var option = (Bank.BankFunctions)int.Parse(Console.ReadLine());
            switch (option)
            {
                case Bank.BankFunctions.Deposit:
                    bank.Deposit();
                    break;
                case Bank.BankFunctions.ViewBalance:
                    bank.ViewBalance();
                    break;
                case Bank.BankFunctions.CreateAccount:
                    bank.CreateAccount();
                    break;
                case Bank.BankFunctions.Transaction:
                    bank.Transaction();
                    break;
            }
        }
    }
}
