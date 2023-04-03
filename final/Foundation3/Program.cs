using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>{};
        Lecture lecture = new Lecture("Casey speaks", "Casey gives a lecture", "3/3/33", "3:33", "10505 ocean blvd", "casey", 25);
        events.Add(lecture);


        Outdoor outdoor = new Outdoor("Math social", "The math department meets to eat", "2/2/22", "10:00", "303 ricks garden", "Snowy");
        events.Add(outdoor);


        Reception reception = new Reception("jake's graduation", "we celebrate jake graduating", "5/4/2023", "9:00", "200 w 3rd south", "jake@email.com");
        events.Add(reception);

        foreach (Event e in events)
        {
            Console.WriteLine(e.FullDetails());
            Console.WriteLine();
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(e.ShortDescription());
            Console.WriteLine();
        }
    
    }
}