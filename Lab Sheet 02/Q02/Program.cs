using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
{
    internal class Program
    {
        class BankAccount
        {
            public string AccountNumber { get; set; }
            public double Balance { get; set; }

            public BankAccount(string accountNumber, double balance)
            {
                AccountNumber = accountNumber;
                Balance = balance;
            }

            public void Deposit(double amount)
            {
                Balance += amount;
            }
        }

        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("235-768-452", 1000);

            double depositAmount = 1500.00;
            myAccount.Deposit(depositAmount);

            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            Console.WriteLine($"Balance: {myAccount.Balance}");

            Console.ReadLine();
        }
    }
}
