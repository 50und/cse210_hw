using System;

public class Breathing : Activity
{
    public Breathing(): base("Breathing", 
                                        "In this activity you will practice conscious breathing. Clear your mind and focus on your breath",
                                        20)
    {

    }

    public void DoIt()
    {
        DisplayStartMessage();
        int delta = 1000;
        int time = _seconds *  1000;
        while (time> 0)
        {
            System.Console.WriteLine("Breathe in...");
            Console.Write(5);
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b");

            Console.Write(4);
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b");

            Console.Write(3);
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b");

            Console.Write(2);
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b");

            Console.Write(1);
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Breathe out...");

            Console.Write(5);
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b");

            Console.Write(4);
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b");

            Console.Write(3);
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b");

            Console.Write(2);
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b");

            Console.Write(1);
            Thread.Sleep(delta);
            time -= delta;
            Console.Write("\b\b");
            Console.WriteLine();
            Console.WriteLine();
            
        }
        End();
    }
}