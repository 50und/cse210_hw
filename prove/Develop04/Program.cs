using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Please pick an activity:");
        Console.WriteLine("1: breathing");
        Console.WriteLine("2: Reflection");
        Console.WriteLine("3: listing");
        int choice = Int32.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Breathing breathing = new Breathing();
                breathing.DoIt();
                break;
            case 2:
                Reflection reflection = new Reflection();
                reflection.DoIt();
                break;
            case 3:
                Listing listing = new Listing();
                listing.DoIt();
                break;

        }
    }
}