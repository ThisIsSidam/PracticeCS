// Name- Anshu Kumar Singh a.k.a. Sidam
// Date- 19/04/2023
// Purpose- C# Practice Programs
// Name of Program- Cash Counter

/*
* The User has an amount of cash on them, and they want to know what will be the change of it. 
* So, take input of user's cash amount and return the number of notes and coins to change it.
* 
* This program uses USDs even though I'm indian, coz I wanna use double in the program and in 
* INR, 0.0one_dollar_note INR which is called Paisa, has already been depricated.
*/

namespace CashCounter;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("== Welcome to the Magical Cash Counter ========\n");

        double money;

        Console.Write("How much money do you have? : ");
        money = Convert.ToDouble(Console.ReadLine());


        double hundred_dollar_note = 100;
        double fifty_dollar_note = 50;
        double twenty_dollar_note = 20;
        double ten_dollar_note = 10;
        double five_dollar_note = 5;
        double two_dollar_note = 2;
        double one_dollar_note = 1;

        double quarter = 0.25;
        double dime = 0.1;
        double nickel = 0.05;
        double penny = 0.01;

        int hundred_dollar_notes = Convert.ToInt32(Math.Floor(money/hundred_dollar_note));
        money %= hundred_dollar_note;

        int fifty_dollar_notes = Convert.ToInt32(Math.Floor(money/fifty_dollar_note));
        money %= fifty_dollar_note;

        int twenty_dollar_notes = Convert.ToInt32(Math.Floor(money/twenty_dollar_note));
        money %= twenty_dollar_note;

        int ten_dollar_notes = Convert.ToInt32(Math.Floor(money/ten_dollar_note));
        money %= ten_dollar_note;

        int five_dollar_notes = Convert.ToInt32(Math.Floor(money/five_dollar_note));
        money %= five_dollar_note;

        int two_dollar_notes = Convert.ToInt32(Math.Floor(money/two_dollar_note));
        money %= two_dollar_note;

        int one_dollar_notes = Convert.ToInt32(Math.Floor(money/one_dollar_note));
        money %= one_dollar_note;

        int quarters = Convert.ToInt32(Math.Floor(money/quarter));
        money %= quarter;

        int dimes = Convert.ToInt32(Math.Floor(money/dime));
        money %= dime;

        int nickels = Convert.ToInt32(Math.Floor(money/nickel));
        money %= nickel;

        int pennies = Convert.ToInt32(Math.Floor(money/penny));
        

        Console.WriteLine("\nThe Change will be:\n");
        Console.WriteLine("100$ Bills: " + hundred_dollar_notes);
        Console.WriteLine("50$ Bills: " + fifty_dollar_notes);
        Console.WriteLine("20$ Bills: " + twenty_dollar_notes);
        Console.WriteLine("10$ Bills: " + ten_dollar_notes);
        Console.WriteLine("5$ Bills: " + five_dollar_notes);
        Console.WriteLine("2$ Bills: " + two_dollar_notes);
        Console.WriteLine("1$ Bills: " + one_dollar_notes);

        Console.WriteLine("Quarters: " +  quarters);
        Console.WriteLine("Dimes: " + dimes);
        Console.WriteLine("Nickels: " + nickels);
        Console.WriteLine("Pennies: " + pennies);

        Console.WriteLine("\n===============================================\n");
    }
}
