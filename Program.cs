using System;


namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //creating the accounts
            BankAccount n1 = new BankAccount("Moses Ataben", 2000, 10000); 
           BankAccount n2 = new BankAccount("Ataben Ataben", 2000, 10000); 
           BankAccount n3 = new BankAccount("Ataben Moses", 2000, 10000); 
           BankAccount n4 = new BankAccount("Moses Moses", 2000, 10000); 
           BankAccount n5 = new BankAccount("Moses AAtaben", 2000, 10000); 

    
        //Methods to call

        //n1.GetDetail();
        //n2.GetDetail();
        //n1.MakeDeposit(1500); 
        //n1.MakeWithdrawal(2000);
        //n1.Balance();
        
           
            
            
        }
    }
}
