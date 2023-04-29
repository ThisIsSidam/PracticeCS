// Purpose- Class file used in Lots Of Accounts

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotsOfAccounts
{
    public class TrustAcc : SavingsAcc
    {
        private static double DepositBonus = 50;
        private static double DepositBonusThreshhold = 5000;
        private static int maxWithdrawal = 3;
        private static double withdrawalLimit = 0.2; //20%
        private int noOfWithdrawals {
            get; set;
        }

        public TrustAcc (string name, double amount, double interest = 0.1)
        : base(name, amount, interest) {
            noOfWithdrawals = 0;
        }

        public override void Deposit(double amount)
        {
            if (amount > DepositBonusThreshhold)
            {
                balance += DepositBonus;
            }
            base.Deposit(amount);
        }

        public override void Withdraw(double amount)
        {
            if (amount > (balance * withdrawalLimit) )
            {
                throw new ArgumentOutOfRangeException($"{this} Only 20% of total balance can be withdrawn at once!");
            }
            if (noOfWithdrawals >= maxWithdrawal)
            {
                throw new ArgumentOutOfRangeException($"{this} You have already withdrawn thrice this year. No withdrawals left!");
            }
            
            noOfWithdrawals++;
            base.Withdraw(amount);
        }

        public override string Display()
        {
            return base.Display() + $" (Withdrawals: {noOfWithdrawals})";
        }
    }
}