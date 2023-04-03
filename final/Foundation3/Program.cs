using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Casey speaks", "Casey gives a lecture", "3/3/33", "3:33", "10505 ocean blvd", "casey", 25);
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine();

        Outdoor outdoor = new Outdoor("Math social", "The math department meets to eat", "2/2/22", "10:00", "303 ricks garden", "Snowy");
        Console.WriteLine(outdoor.FullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.ShortDescription());
        Console.WriteLine();


        Reception reception = new Reception("jake's graduation", "we celebrate jake graduating", "5/4/2023", "9:00", "200 w 3rd south", "jake@email.com");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.ShortDescription());    
    
    }
}