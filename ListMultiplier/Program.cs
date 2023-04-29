// Name- Anshu Kumar Singh a.k.a. Sidam
// Date- 24/04/2023
// Purpose- C# Practice Programs
// Name of Program- List Multiplier

/*
* This time you have to create a program that asks the user for two arrays and gives back the
* multiplication of both the arrays. Do it the way we multiply (3, 5)*(5, 3, 3).
*/

namespace ListMultiplier;
class Program
{
    static unsafe void Main(string[] args)
    {
        Console.WriteLine("== Sidam's List Multiplier Activated ========");

        string ask;
        do {
            
            Console.Write("\nDo you wanna multiply two lists? YES/NO : ");
            ask = Console.ReadLine()!;

            if ( ask == "YES" )
            {   
                int [] array_one = GetArray(1);
                int [] array_two = GetArray(2);

                int [] multiplied_array = MultiplyArray(array_one, array_two);

                DisplayArray(multiplied_array);
            }
            else if ( ask == "NO" )
            {
                Console.WriteLine("Goodbye :)");
            }
            else 
            {
                Console.WriteLine("Invalid Value Given! Valid Values- YES, No. Note: All Capital.");
            }

        } while ( ask != "NO" );


        Console.WriteLine("=============================================\n");
    }

    static int[] GetArray( int num ) {
        
        Console.Write("Enter Size of Array " + num + ": ");
        int size = Convert.ToInt32(Console.ReadLine());

        int [] array = new int[size];
        
        for ( int i = 0; i < size; i++ )
        {
            Console.Write("Enter Element " + (i + 1) + ": ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        return array;
    }

    static int[] MultiplyArray (int[] array1, int[] array2) {

        int [] array3 = new int [array1.Length * array2.Length];

        int array3_index = 0;
        foreach ( int i in array1 )
        {
            foreach ( int j in array2 )
            {
                array3[array3_index] = i * j;
                array3_index++;
            }
        }

        return array3;
    }

    static void DisplayArray( int[] array ) {
        Console.Write("[ ");

        foreach(int i in array)
        {
            Console.Write(i + " ");
        }

        Console.Write("]\n");
    }

}
