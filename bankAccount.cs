using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationExample
{
    class BankAccount
    {
        private string password;
        private double balance;

        public BankAccount()
        {
            balance = 0;
        }

        public BankAccount(string p)
        {
            password = p;
            balance = 0;
        }

        public bool Deposit(double amount, string pword)
        {
            if (pword == password &&
                amount > 0)
            {
                balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Withdrawal(double amount, string pword)
        {
            if (pword == password
                && (balance - amount) >= 0)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return balance.ToString("$0.00");
        }
    }
}
