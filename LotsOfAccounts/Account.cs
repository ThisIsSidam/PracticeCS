// Purpose- Class file used in Lots Of Accounts

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotsOfAccounts
{
    public abstract class Account
    {
        public long account_no {
            get;
        }
        public string name {
            get;
        }
        public double balance {
            get; set;
        }

        static protected long AccountNoPreset = 9910990001;
        public Account (string name, double amount)
        {
            this.name = name;
            balance = amount;
            account_no = AccountNoPreset;
            AccountNoPreset++;
        } 

        public virtual void Deposit (double amount) {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException($"{this} Can't deposit negative amount!");
            }
            balance += amount;
        }

        public virtual void Withdraw (double amount) {
            if (amount > this.balance) 
            {
                throw new ArgumentOutOfRangeException($"{this} Not enough balance!");
            }
            balance -= amount;
        }

        public virtual string Display () {
            return $"{account_no} {name} {balance}";
        }

        public override string ToString() {
                return this.Display();
        }
    }
}