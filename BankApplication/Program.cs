using System;
using System.Collections.Generic;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount n1 = new BankAccount("Moses Ataben", 2000, 10000);  
            
            Console.WriteLine($"The Account {n1.Number} was created by {n1.Owner} with a minimuim balance {n1.minBalance} and maximuim balance {n1.maxBalance}.");

            BankAccount n2 = new BankAccount("John Ataben", 2000, 10000);  
            
            Console.WriteLine($"The Account {n2.Number} was created by {n2.Owner} with a minimuim balance {n2.minBalance} and maximuim balance {n2.maxBalance}.");

            BankAccount n3 = new BankAccount("Michsel Ataben", 2000, 10000);  
            
            Console.WriteLine($"The Account {n3.Number} was created by {n3.Owner} with a minimuim balance {n3.minBalance} and maximuim balance {n3.maxBalance}.");

            BankAccount n4 = new BankAccount("Mary Ataben", 2000, 10000);  
            
            Console.WriteLine($"The Account {n4.Number} was created by {n4.Owner} with a minimuim balance {n4.minBalance} and maximuim balance {n4.maxBalance}.");

            BankAccount n5 = new BankAccount("Momica Ataben", 2000, 10000);  
            
            Console.WriteLine($"The Account {n5.Number} was created by {n5.Owner} with a minimuim balance {n5.minBalance} and maximuim balance {n5.maxBalance}.");
        }
    }
}
