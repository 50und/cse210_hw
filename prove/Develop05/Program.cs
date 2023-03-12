using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        // do a split, then use if statements to figure out which object to create
        // use a colon to separate the type from the information
        // read the first line to get the points, then use the loop to decode the rest of the objects


        string [] lines = System.IO.File.ReadAllLines("");
        int total = Int32.Parse(lines[0]);

        List<Goal> goals = new List<Goal>{};

        foreach (string l in lines)
        {
            string [] line = l.Split(":");
            string goalType = line[0];
            if (goalType ==  "Simple")
            {
                Simple s = new Simple(line[1]);
                goals.Add(s);
            }
            else if (goalType == "Eternal")
            {
                Eternal e = new Eternal(line[1]);
                goals.Add(e);
            }
            else if (goalType== "Checklist")
            {
                Checklist c = new Checklist(line[1]);
                goals.Add(c);
            }
        }
        




    }
}