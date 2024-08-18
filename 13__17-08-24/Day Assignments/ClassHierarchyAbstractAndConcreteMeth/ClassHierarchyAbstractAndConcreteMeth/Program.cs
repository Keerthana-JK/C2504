//9.Implement a Class Hierarchy with Abstract Methods and Concrete Methods
//   - Task: Create an abstract class `Transaction` with an abstract method `Execute()`. Create a concrete method `LogTransaction()` in `Transaction` to log transaction details.
//          Derive classes `Deposit` and `Withdrawal` from `Transaction`.
//   - Requirements:
//     - `Deposit` should have a property `Amount` and implement `Execute()` to simulate a deposit transaction.
//     - `Withdrawal` should have a property `Amount` and implement `Execute()` to simulate a withdrawal transaction.

using System;

namespace ClassHierarchyAbstractAndConcreteMeth
{
    internal class Program
    {
        abstract class Transaction
        {
            public abstract void Execute();
            public void LogTransaction()
            {
                Console.WriteLine("Logging transaction...");
            }
        }

        class Deposit : Transaction
        {
            int Amount;

            public Deposit(int Amount)
            {
                this.Amount = Amount;
            }

            public override void Execute()
            {
                Console.WriteLine($"Depositing {Amount}");
            }
        }
        class Withdrawal : Transaction
        {
            int Amount;
            public Withdrawal(int Amount)
            {
                this.Amount = Amount;
            }
            public override void Execute() 
            {
                Console.WriteLine($"Withdrawing {Amount}");
            }
        }
        static void Main(string[] args)
        {
            Transaction deposit = new Deposit(1000);
            deposit.Execute();
            deposit.LogTransaction();

            Transaction withdrawal = new Withdrawal(500);
            withdrawal.Execute();
            withdrawal.LogTransaction();
        }
    }
}
