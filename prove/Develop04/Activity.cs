using System;

public class Activity
{
    private string _name = "";
    private string _description = "";
    protected int _seconds = -1;
    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _seconds = duration;
    }

    public void End()
    {
        System.Console.WriteLine("Thank you!");
        DisplayDelay(2);
        System.Console.WriteLine($"You just completed the {_name} Activity, this took {_seconds} seconds");
        DisplayDelay(2);
    }
    
    public void SetDuration()
    {
        System.Console.WriteLine($"How long do you want to do the {_name} activity?");
        _seconds = Int32.Parse(System.Console.ReadLine());
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine();
        System.Console.WriteLine($"You selected the {_name} activity");
        System.Console.WriteLine($"{_description}");
        SetDuration();
    }

    public int GetDuration()
    {
        return _seconds;
    }
    public void DisplayDelay(int delay)
    {
        int delta = 500;
        double time = delay * 1000;
        while (time > 0)
        {
            Console.Write("+");
            
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b"); // Erase the + character    
            Console.Write("-"); // Replace it with the - character

            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b"); // Erase the - character    
        }
        Console.Write("\b\b");
    }
}