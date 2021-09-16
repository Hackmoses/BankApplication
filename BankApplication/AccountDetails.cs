
using System.Transactions;
using System;
using System.Collections.Generic;

namespace BankAccounts
{
    public class BankAccount
    {
        //properties
        public string Owner { get; set; }

        public string Number { get; set; }
        public decimal minBalance {get; set; }
        public decimal maxBalance { get; set;}
             

        private static int accountNumber = 0123456789;



        //create List to store transaction

        private List<Transaction> allActivity = new List<Transaction> ();

        //constructors

        public BankAccount(string Owner, decimal minBalance, decimal maxBalance)
        {
            this.Owner = Owner;
            this.minBalance = minBalance;
            this.maxBalance = maxBalance;

            MakeDeposit(maxBalance, DateTime.Now);

            MakeWithdrawal(-maxBalance, DateTime.Now);
            

            this.Number = accountNumber.ToString();
            accountNumber++;




        }

        //methods
        public void MakeDeposit(decimal amount, DateTime date) {

            if (amount <= 0)
            {
                 Console.Write("Amount must be greater than Zero"); 
            }

            Transaction deposit = new Transaction(amount, date);
            allActivity.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date) {

            if (minBalance - amount < 0)
            {
                Console.Write("Insufficient Fund");                

            }
            Transaction withdraw = new Transaction(-amount, date);
            allActivity.Add(withdraw);
            
        }
    }
}
