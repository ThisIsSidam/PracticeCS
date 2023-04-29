// Name- Anshu Kumar Singh a.k.a. Sidam
// Date- 18/04/2023
// Purpose- C# Practice Programs
// Name of Program- Frank's Room Cleaning Service

/*
* Create a program for a room cleaning service, take input of how many rooms are to be cleaned.
* Show prices, which are, 35$ for large room, and 25$ for small ones. Tax is 2%, also tell the total 
* estimate will be valid for a 30days. Name of the service is - Frank Room Cleaning Service.
*/

namespace LearningCS;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n== Welcome to Frank Room Cleaning Service ========");

        const double large_room_rate= 35.0;
        const double small_room_rate = 25.0;
        const double tax = 0.02; // 2% Tax

        Console.WriteLine("\n== Current Rates ==");

        Console.WriteLine("Large Room -> " + large_room_rate);
        Console.WriteLine("Small Room -> " + small_room_rate);
        Console.WriteLine("Tax        -> " + ( tax * 100) + "%");

        Console.WriteLine("\n===================");

        int large_rooms_to_clean;
        int small_rooms_to_clean;

        Console.Write("How many Large Rooms would you like cleaned? : ");
        large_rooms_to_clean = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many Small Rooms would you like cleaned? : ");
        small_rooms_to_clean = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n== Bill ==========");

        double large_room_cost = large_room_rate * large_rooms_to_clean + (large_room_rate * large_rooms_to_clean * tax);
        double small_room_cost = small_room_rate * small_rooms_to_clean + (small_room_rate * small_rooms_to_clean * tax);

        Console.WriteLine("Large Room : " + large_room_cost);
        Console.WriteLine("Small Room : " + small_room_cost);       
        Console.WriteLine("Total      : " + (large_room_cost + small_room_cost) );

        Console.WriteLine("This estimate is valid for only the next 30 days.");
        
        Console.WriteLine("\n==================================================");

    }
}
