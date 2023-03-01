using System;

public class Reflection: Activity
{
    private List<string> _prompts = new List<string>{"Think of a time you stood up for someone else",
    "Think of a time when you did something difficult",
    "Think of a time when you helped someone in need",
    "Think of a time  when you did something truly selfless"};

    private List<string> _questions = new List<string>{"Why was that experience meaningful?",
    "Have you ever doen anything like this before?",
    "How did you get started?",
    "how did you feel when it was complete?",
    "What made this time different than other times when you were not as successful",
    "What is your favorite thing about this experience?",
    "Waht could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"};
    public Reflection(): base("Reflection",
    "This activity will help you refelct on times in your life when you have shown strength and resilience.",
    20)
    {

    }

    public void DoIt()
    {
        DisplayStartMessage();
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(prompt);
        int time = _seconds;

        int q_index = 0;
        while (time>0)
        {
            Console.WriteLine();
            Console.WriteLine(_questions[q_index]);
            q_index = (index+1) % _questions.Count;
            DisplayDelay(20);
            time -= 20;
            Console.WriteLine();
            
        }
        End();


    }

    
}