using System;

public class Listing: Activity
{
    public Listing(): base("Listing",
    "This activity will help you reflect on your blessings by having you list as many things as you can on a certain subject",
    60)
    {}

    private List<string> _prompts = new List<string>{"Who are people that you appreciate",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};

    public void DoIt()
    {
        DisplayStartMessage();
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(_prompts[index]);


        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);
        // DateTime currentTime = DateTime.Now;
        DisplayDelay(3);

        int count = 0;
        while (DateTime.Now < futureTime)
        {
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items in response to: \n{_prompts[index]}");
        End();

    }

}