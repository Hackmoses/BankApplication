

using System;

namespace BankAccounts
{
    public class BankAccount
    {
        //properties
        public string Owner;
        public string AccountNumber{get;}
        public double MinBalance = 2000;
        public double MaxBalance = 10000;
             
        private static  int Number = 0123456789;

        public BankAccount(string Owner, double MinBalance, double MaxBalance) 
        {
            this.Owner = Owner;
            this.MinBalance = MinBalance;
            this.MaxBalance = MaxBalance;

            this.AccountNumber = Number.ToString();
            Number++;
            
        }

        public void MakeDeposit(double amount) {
            MaxBalance = MaxBalance + amount;
            Console.WriteLine("You have deposited " + amount + " from your account, Total balance is " + MaxBalance);
        }

         public void MakeWithdrawal(double amount) {
            
            MaxBalance = MaxBalance - amount;
            Console.WriteLine("You have withdrawn " + amount + " from your account, Total balance is " + MaxBalance);

        }


        public void Balance() {
            Console.WriteLine(MaxBalance);
        }

        public void GetDetail() {
            Console.WriteLine("Your name is " + Owner + ",Your maximuim account balance is " + MaxBalance + " Your account number is : " + AccountNumber );
        }
        





      
    }
}
