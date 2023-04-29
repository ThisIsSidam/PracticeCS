// Name- Anshu Kumar Singh a.k.a. Sidam
// Date- 26/04/2023
// Purpose- C# Practice Programs
// Name of Program- Lots of Accounts

/*
Create four types of account classes, one of a normal Account, then
Savings Account, Checking Account and Trust Account. Which class will be derived by 
which class is up to you to decide. Things that you have to add in the classes are-

Account- Name, Balance

Savings Acc- Name, Balance, Interest Rate (That much interest gets added per deposit)

Checking Acc- Name, Balance and a withdrawal fee of 1.50$ per withdrawal

Trust Acc- Name, Balance, Interest Rate, Any deposit of $5000.00 or more gets flat $50 
Bonus, the deposit function works just like of savings account, and only 3 withdrawal 
of less than 20% of balance is allowed per year.

Also, you have to create utility functions by which we can see all the accounts at once.
What you have to do is add all the objects created into a List and give it to the functions
that deposit, withdraw and display all accounts at once.
*/

namespace LotsOfAccounts;
class Program
{
    static void Main(string[] args)
    {
        List<Account> avengers = new List<Account>();
        avengers.Add(new SavingsAcc("Steve Rogers", 64633));
        avengers.Add(new CheckingAcc("Bruce Banner", 434235));
        avengers.Add(new TrustAcc("Tony Stark", 35345545));

        massDeposit(ref avengers, 1000);
        massDisplay(ref avengers);

        massWithdraw(ref avengers, 5434);
        massDisplay(ref avengers);

        massWithdraw(ref avengers, 32345);
        massDisplay(ref avengers);

        massWithdraw(ref avengers, 32345000);
        massDisplay(ref avengers);

        massWithdraw(ref avengers, 100);
        massWithdraw(ref avengers, 100);
        massDisplay(ref avengers);
    }

    static void massDeposit(ref List<Account> accounts, double amount) {
        foreach (var acc in accounts)
        {
            try
            {
                acc.Deposit(amount);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch
            {
                Console.WriteLine("Something Went Wrong!");
            }
        }
    } 

    static void massWithdraw (ref List<Account> accounts, double amount) {
        foreach (var acc in accounts)
        {
            try
            {
                acc.Withdraw(amount);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch 
            {
                Console.WriteLine("Something Went Wrong");
            }
        }
    }

    static void massDisplay (ref List<Account> accounts) {
        foreach (var acc in accounts)
        {
            try
            {
                Console.WriteLine(acc);
            }
            catch
            {
                Console.WriteLine("Something Went Wrong!");
            }
        }
        Console.WriteLine();
    }
}
