// Purpose- Class file used in Lots Of Accounts

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotsOfAccounts
{
    public class SavingsAcc : Account
    {
        public double interest;

        public SavingsAcc (string name, double amount, double interest = 0.05) 
        : base (name, amount) 
        {
            this.interest = interest;
        }

        public override void Deposit (double amount)
        {
            amount += (amount * interest);
            base.Deposit(amount);
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
        }

        public override string Display()
        {
            return base.Display() + $" {Convert.ToInt32(interest * 100)}%";
        }

    }
}