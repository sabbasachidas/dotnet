using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    public class AccountCreation
    {
        public string accountNo;
        public string customerName;
        public double amount;
        public double balance;

        public bool Deposit(double amount)
        {
            balance = balance + amount;
            return true;
        }
        public bool Widthdraw(double amount)
        {
            balance = balance - amount;
            return true;
        }
        public string GetReport()
        {
            var message = "Name: " +customerName + " Account No: " + accountNo + " Balance: " + balance;
            return message;
        }
        
    }
}
