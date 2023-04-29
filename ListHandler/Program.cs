// Name- Anshu Kumar Singh a.k.a. Sidam
// Date- 22/04/2023
// Purpose- C# Practice Programs
// Name of Program- List Handler

/*
* You have a list of numbers. You have to show the user options, for printing the list, adding numbers in the list,
* Finding the average, finding the smallest and the largest number, Search for a number. Also, don't allow
* duplicates, and also allow an option to clear out the list. And print out the list everytime in square brackets.
* Now Go!
*/

namespace ListHandler;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("== Sidam's List Handler Activated =====");

        List<int> list = new List<int>();

        int choice;

        do {
            ShowMenu();
            choice = Convert.ToInt32(Console.ReadLine());
            

            // Only those options that can be used on an empty list.
            if ( list.Count == 0 )
            {
                switch ( choice ) {
                    case 2 : {
                        int num = GetNum();
                        bool flag = AddNum( ref list, ref num);
                        OperationResult(flag);
                        break;
                    }
                    case 0 : {
                        Console.WriteLine("GoodBye :)");
                        break;
                    }
                    default : {

                        // Showing that the list is empty for other choices.
                        if ( (choice == 1) | (choice == 3) | (choice == 4) | (choice == 5)
                                | (choice == 6) | (choice == 7) | (choice == 8) )
                        {
                            Console.WriteLine("The List is Empty [] :(");
                        }
                        else 
                        {
                            Console.WriteLine("Invalid Value Entered!");
                        }
                        break;
                    }
                }
            }

            // Now, all choices are available when the list isn't empty.
            else 
            {    
                switch (choice) 
                {
                    case 1 : {
                        PrintList(ref list);
                        break;
                    }
                    case 2 : {
                        int num = GetNum();
                        bool flag = AddNum( ref list, ref num);
                        OperationResult(flag);
                        break;
                    }
                    case 3 : {
                        int num = GetNum();
                        bool flag = RemoveNum( ref list, ref num);
                        OperationResult(flag);
                        break;
                    }
                    case 4 : {
                        Console.WriteLine("Average: " + list.Average());
                        break;
                    }
                    case 5 : {
                        Console.WriteLine("Smallest Number: " + SmallestNum(ref list));
                        break;
                    }
                    case 6 : {
                        Console.WriteLine("Largest Number: " + LargestNum(ref list));
                        break;
                    }
                    case 7 : {
                        int num = GetNum();
                        int index = Search(ref list, ref num);

                        if ( index == -1 )
                        {
                            Console.WriteLine("The Number is not Present in the List. :(");
                            break;
                        }

                        Console.WriteLine("Index: " + index );
                        break;
                    }
                    case 8 : {
                        list.Clear();
                        OperationResult(true);
                        break;
                    }
                    case 0 : {
                        Console.WriteLine("GoodBye :)");
                        break;
                    }
                    default : {
                        Console.WriteLine("Invalid Value Entered!");
                        break;
                    }
                }
            }
            
        } while ( choice != 0 );

        
        Console.WriteLine("=======================================");
    }

    static void ShowMenu() {
        Console.Write("\nWhat do you want to do?" +
                      "\n1 - Print the List" + 
                      "\n2 - Add a Number to the List" +
                      "\n3 - Remove a Number from the List" + 
                      "\n4 - Find Average" + 
                      "\n5 - Find Smallest Number" +
                      "\n6 - Find Largest Number" +
                      "\n7 - Search a Number" +
                      "\n8 - Clear the List" +
                      "\n0 - Quit" +
                      "\n\nEnter: ");
    }

    static void PrintList(ref List<int> list) {
        
        if ( list.Count == 0 ) {

        }

        Console.Write("[ ");
        
        foreach(int i in list)
        {
            Console.Write(i + " ");
        }

        Console.Write("]\n");
    }

    static int GetNum() {
        Console.Write("Enter the Number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void OperationResult(bool flag) {
        if ( flag == true ) 
        {
            Console.WriteLine("Operation Was Successful :)");
            return;
        }
        Console.WriteLine("Something Went Wrong!");
    }

    static bool Check(ref List<int> list, ref int num) {
        for ( int i = 0; i < list.Count; i++)
        {
            if ( list[i] == num )
            {
                return true;
            } 
        }

        return false;
    }
    static int Search(ref List<int> list, ref int num) {
        
        if ( Check(ref list, ref num) )
        {
            for ( int i = 0; i < list.Count; i++)
            {
                if ( list[i] == num )
                {
                    return i;
                } 
            }
        }

        return -1;
    }

    static bool AddNum(ref List<int> list, ref int num) {

        if ( Check( ref list, ref num) )
        {
            return false;
        }

        list.Add(num);
        return true;;
    }

    static bool RemoveNum(ref List<int> list, ref int num) {

        int pos = Search(ref list, ref num);

        if ( pos == -1 )
        {
            return false;
        }

        list.Remove(num);
        return true;  
    }

    static int SmallestNum(ref List<int> list) {
        
        int smallest_num = int.MaxValue;

        foreach (int i in list) 
        {
            if ( i < smallest_num )
            {
                smallest_num = i;
            }
        }

        return smallest_num;
    }

    static int LargestNum(ref List<int> list) {

        int largest_num = int.MinValue;

        foreach (int i in list) 
        {
            if ( i > largest_num )
            {
                largest_num = i;
            }
        }

        return largest_num;

    }
}