// Name- Anshu Kumar Singh a.k.a. Sidam
// Date- 20/04/2023
// Purpose- C# Practice Programs
// Name of Program- Substitution Cypher

/*
* You have to first ask if the user wants to encrypt or decrypt a code. Then do so.
* Have two strings, first of normal abc letters, and second of the replacement of those letters.
* And switch them for encrypting and decrypting.
*/

namespace SubstitutionCypher;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("== Sidam's Cipher Site Activated =====\n");

        string alphabets = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 ";
        string substitute = "1342765098AbCdEfGhIjKlMnOpQrS tUvWxYzaBcDeFgHiJkLmNoPqRsTuVwXyZ";


        int choice;
        do {

            Console.Write("\nWhat do you want to do?\n1. Encrypt\n2. Decrypt\n0. Quit\n\nEnter: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) {

                case 1: 
                {
                    Console.Write("\nEnter the message: ");

                    string message = Console.ReadLine()!;

                    Console.Write("Encrypted Message: ");

                    bool found;
                    for (int i = 0; i < message.Length; i++)
                    {   
                        found = false;
                        for (int j = 0; j < alphabets.Length; j++)
                        {
                            if ( message[i] == alphabets[j])
                            {
                                found = true;
                                Console.Write(substitute[j]);
                            } 
                        } 
                        if ( found == false )
                        {
                            Console.Write(message[i]);
                        }
                    }

                    Console.WriteLine();
                    break;
                }
                case 2: 
                {
                    Console.Write("\nEnter the secret message: ");

                    string message = Console.ReadLine()!;

                    Console.Write("Decrypted Message: ");

                    bool found;
                    for (int i = 0; i < message.Length; i++)
                    {
                        found = false;
                        for (int j = 0; j < substitute.Length; j++)
                        {
                            if ( message[i] == substitute[j])
                            {
                                found = true;
                                Console.Write(alphabets[j]);
                            }
                        }
                        if ( found == false)
                        {
                            Console.Write(message[i]);
                        }
                    }

                    Console.WriteLine();
                    break;
                }

                case 0:
                {
                    Console.WriteLine("GoodBye!");
                    break;
                }
                default:
                {
                    Console.WriteLine("Illegal Value Entered!");
                    break;
                }
            }

        } while ( choice != 0);


        Console.WriteLine("======================================");
    }

}
