using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>{};

        Running run = new Running("03 Nov 2022", 10.6, 1);
        exercises.Add(run);

        Swimming swim = new Swimming("04 Nov 2022", 30.6, 30);
        exercises.Add(swim);

        Cycling cycle = new Cycling("05 Nov 2022", 30.8, 10);
        exercises.Add(cycle);

        foreach (Exercise e in exercises)
        {
            Console.WriteLine();
            Console.WriteLine(e.Summary());
        }

    }
}