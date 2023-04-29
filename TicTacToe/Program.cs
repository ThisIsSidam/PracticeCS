// Name- Anshu Kumar Singh a.k.a. Sidam
// Date- 28/04/2023
// Purpose- C# Practice Programs
// Name of Program- Tic Tac Toe


namespace TicTacToe;
class Program
{
    static void Main(string[] args)
    {
        string ask;

        string User = FirstTime();

        Play(ref User);

        do {

            Console.Write("\nDo you want to play again? YES/NO : ");
            ask = Console.ReadLine()!;

            if ( ask == "YES")
            {
                Play(ref User);
            }
            else if ( ask == "GUIDE")
            {
                Guidelines();
            }
            else if (ask == "NO")
            {
                Console.WriteLine("Goodbye :)");
                break;
            }
            else 
            {
                Console.WriteLine("Illegal Input Entered!");
            }

        } while (true);
    }

    public static void Guidelines() {
    // Displays the guidelines.

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("\n1. Enter only 'YES' or 'NO'. In all capitals." +
                          "\n2. Enter 'O' or 'x' in all caps too." +
                          "\n3. When it's your chance, enter the number on the block to select that block." +
                          "\n4. Enter 'GUIDE' in all caps to see the guidelines again.");
        
        Console.ResetColor();
    }

    public static string FirstTime() {
    // Shows the guide and asks for user to select between O and X.
    
        Guidelines();

        string User;
        Console.Write("\nWhich do you wanna pick? O/X : ");
        User = Console.ReadLine()!;

        while ((User != "O") && (User != "X"))
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nIllegal Input!\nEnter your choice again: ");
            Console.ResetColor();

            User = Console.ReadLine()!;
        }

        return User;
    }

    public static void Play(ref string User) {
    // Everything about the game happens here.

        string Bot;
        if ( User == "O")
        {
            Bot = "X";
        }
        else 
        {
            Bot = "O";
        }

        var positions = new List<string> {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
        var available_positions = new List<string> {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

        DisplayBoard(positions);

        bool game_over = false;
        int moves = 0;
        do {
            
            Console.Write("Your turn: ");
            string choice = Console.ReadLine()!;

            while (! UpdateBoard(ref User, ref choice, positions, available_positions) )
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Illegal Input!\nEnter your choice again: ");
                choice = Console.ReadLine()!;

                Console.ResetColor();
            }
            moves++;
            Console.Clear();
            DisplayBoard(positions);
            
            if (moves > 4)
            {
                game_over = GameCheck(positions, User);
                if (game_over)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("You Won :) ");

                    Console.ResetColor();
                    break;
                }
            }

            botMove(ref Bot, positions, available_positions);
            moves++;

            Console.Clear();
            DisplayBoard(positions);
            
            if (moves > 4)
            {
                game_over = GameCheck(positions, Bot);
                if (game_over)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("You Lost :( ");

                    Console.ResetColor();
                    break;
                }
            }
           
        } while (true);

    }

    public static void DisplayBoard(List<string> pos) {
    // Displays the game board.

        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("\n"+
                        $"              |             |             \n" +
                        $"  {QF(pos[0])}| {QF(pos[1])}|{QF(pos[2])} \n" +
                        $" _____________|_____________|_____________\n" +
                        $"              |             |             \n" +
                        $"  {QF(pos[3])}| {QF(pos[4])}|{QF(pos[5])} \n" +
                        $" _____________|_____________|_____________\n" +
                        $"              |             |             \n" +
                        $"  {QF(pos[6])}| {QF(pos[7])}|{QF(pos[8])} \n" +
                        $"              |             |             \n"
                        );

        Console.ResetColor();          
    }

    public static string QF(string str) {
        // Quick Format
        // Named it small to call it quick in the DisplayBoard method.

        return String.Format("{0, 6}      ", str);
    }

    public static bool UpdateBoard(ref string player, ref string choice, List<string> pos, List<string> avail_pos) {
    // Updates the game board.

        if (!avail_pos.Contains(choice)) 
        {
            return false;
        }

        for (var i = 0; i < avail_pos.Count; i++ )
        {
            if ( pos[i] == choice)
            {
                pos[i] = player;
                avail_pos.Remove(pos[i]);
                return true;
            }
        }
       
        return false;
    }

    public static bool botMove(ref string bot, List<string> pos, List<string> avail_pos) {
    // Manages the move the bot takes.

        var rnd = new Random();
        int choice_index = rnd.Next(avail_pos.Count);


        while (! avail_pos.Contains(pos[choice_index]))
        {
            choice_index = rnd.Next(avail_pos.Count);
        }
        
        string bot_choice = Convert.ToString(avail_pos[choice_index]);
        return UpdateBoard(ref bot, ref bot_choice, pos, avail_pos);
    }

    public static bool GameCheck(List<string> pos, string player) {
    // Checks if the game is over.

        var index_of_pos = new List<string> ();

        string [,] winning_pos = {
            {"0", "1", "2"}, {"3", "4", "5"}, {"6", "7", "8"},
            {"0", "3", "6"}, {"1", "4", "7"}, {"2", "5", "8"},
            {"0", "4", "8"}, {"2", "4", "6"}
        };

        for ( var i = 0; i < pos.Count; i++) 
        {
            if ( pos[i] == player)
            {
                index_of_pos.Add(Convert.ToString(i));
            }
        }

        for ( var i = 0; i < winning_pos.GetLength(0); i++)
        {
            var flag = new List<bool> {false, false, false};

            for ( var j = 0; j < winning_pos.GetLength(1); j++)
            {
                if (! index_of_pos.Contains(winning_pos[i,j]))
                {
                    break;
                }
                flag[j] = true;
            }

            if (flag[2] == true)
            {
                return true;
            }
            
        }

        return false;
    }
}
