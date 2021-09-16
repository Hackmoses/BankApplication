using System.Transactions;
using System;
using System.Collections.Generic;

namespace BankAccounts
{
    public class Transaction
    {
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    
    public Transaction(decimal Amount, DateTime Date) {

        this.Amount = Amount;
        this.Date = Date;
    }
     
    }
}