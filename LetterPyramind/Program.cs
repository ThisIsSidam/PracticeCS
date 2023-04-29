// Name- Anshu Kumar Singh a.k.a. Sidam
// Date- 21/04/2023
// Purpose- C# Practice Programs
// Name of Program- Letter Pyramid

/* 
* Get Input from the user, and make a pyramid out of it. Something like this-
* Input = ABC
* Pyramid:
* 
*   A
*  BAB
* CBABC
*
*/

namespace LetterPyramind;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("== Sidam's Pyramid Maker Activated ========");

        Console.WriteLine("Note: Enter 'QUIT' as the letters for the pyramid to end the program.");

        string letters; 
        do {

            Console.Write("\nEnter the letters for the Pyramid: ");
            letters = Console.ReadLine()!;

            if ( letters == "QUIT")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            for ( int i = 0; i < letters.Length; i++ )
            {
                for ( int j = ( letters.Length - i ); j > 0; j-- )
                {
                    Console.Write(" ");
                }
                for ( int j = i; j > 0; j--)
                {
                    Console.Write(letters[j]);
                }
                for ( int j = 0; j <= i; j++)
                {
                    Console.Write(letters[j]);
                }

                Console.WriteLine();
            }

        } while (true);


        Console.WriteLine("===========================================");
    }
}
