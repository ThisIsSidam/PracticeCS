// Purpose- Class file used in Lots Of Accounts

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotsOfAccounts
{
    public class CheckingAcc : Account
    {
        private static double WithdrawalCharge = 1.5;

        public CheckingAcc(string name, double amount)
        : base(name, amount) {}

        public override void Withdraw(double amount)
        {
            if (balance < WithdrawalCharge) {
                throw new ArgumentOutOfRangeException($"{this} Not enough balance for withdrawal charge deduction!");
            }
            balance -= WithdrawalCharge;
            base.Withdraw(amount);
        }
        
    }
}