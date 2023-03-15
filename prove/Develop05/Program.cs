using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>{};
        // do a split, then use if statements to figure out which object to create
        // use a colon to separate the type from the information
        // read the first line to get the points, then use the loop to decode the rest of the objects

        int option = 0;
        int points = 0;
        while (option != 6)
        {
            Console.WriteLine();
            Console.WriteLine("Please pick an option");
            Console.WriteLine("1: Load goals from a file");
            Console.WriteLine("2: Add new goal");
            Console.WriteLine("3: Complete a goal");
            Console.WriteLine("4: Save your goals to a file");
            Console.WriteLine("5: Display your goals");
            Console.WriteLine("6: Quit");
            option = Int32.Parse(Console.ReadLine());
            if (option == 1)
            {
                Load();
            }
            else if (option == 2)
            {
                AddGoal();
            }
            else if (option == 3)
            {
                int index = 0;
                foreach (Goal goal in goals)
                {
                    Console.WriteLine($"Goal {index}");
                    goal.Display();
                    index +=1;
                }
                Console.WriteLine("Type the number of the goal you completed");
                index = Int32.Parse(Console.ReadLine());
                if (goals[index].GetCompleted()== "")
                {
                    points += goals[index].DoIt();
                    Console.WriteLine($"Good Job! You added {goals[index].DoIt()} points, making your total {points}");
                }
                else if (goals[index].GetCompleted()=="X")
                {
                    Console.WriteLine("You've already completed that goal");
                }
            }
            else if (option == 4)
            {
                System.Console.WriteLine("Enter a name for your file: ");
                string fileName = System.Console.ReadLine();
                using (StreamWriter _outputFile = new StreamWriter(fileName))
                {
                    _outputFile.WriteLine(points);
                    foreach (Goal goal in goals)
                    {
            
                        _outputFile.WriteLine(goal.GetStringRepresentation());

                    }
                }
            }
            else if (option ==5)
            {
                Console.WriteLine($"You have {points} points");
                foreach (Goal goal in goals)
                {
                    goal.Display();
                }
            }
        }
        void Load()
        {
            Console.WriteLine("What is the name of your file? ");
            string filename = Console.ReadLine();
            string [] lines = System.IO.File.ReadAllLines(filename);
            points = Int32.Parse(lines[0]);
            goals.Clear();
            foreach (string l in lines[1..lines.Count()])
            {
                string [] line = l.Split(":");
                string goalType = line[0];
                if (goalType.Contains("Simple") ==  true)
                {
                    Simple s = new Simple(line[1]);
                    goals.Add(s);
                }
                else if (goalType.Contains("Eternal") == true)
                {
                    Eternal e = new Eternal(line[1]);
                    goals.Add(e);
                }
                else if (goalType.Contains("Checklist")== true)
                {
                    Checklist c = new Checklist(line[1]);
                    goals.Add(c);
                }
            }
        }

        void AddGoal()
        {          
            int goal = 0;    
            Console.WriteLine("What kind of goal would you like to add?");
            Console.WriteLine("1: Simple");
            Console.WriteLine("2: Eternal");
            Console.WriteLine("3: Checklist");
            Console.WriteLine();
            goal = Int32.Parse(Console.ReadLine());

            if (goal == 1)
            {
                Console.WriteLine("How many points should this give?");
                int goal_points = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Write a title for your goal");
                string goal_title = Console.ReadLine();
                Console.WriteLine("Describe your goal");
                string goal_description = Console.ReadLine();

                Simple simple = new Simple(goal_points, goal_title, goal_description);
                goals.Add(simple);
            }

            else if (goal == 2)
            {
                Console.WriteLine("How many points should this give?");
                int goal_points = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Write a title for your goal");
                string goal_title = Console.ReadLine();
                Console.WriteLine("Describe your goal");
                string goal_description = Console.ReadLine();
                Eternal eternal = new Eternal(goal_points, goal_title, goal_description);
                goals.Add(eternal);
            }
            else if (goal == 3)
            {
                Console.WriteLine("How many points should this give?");
                int goal_points = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Write a title for your goal");
                string goal_title = Console.ReadLine();
                Console.WriteLine("Describe your goal");
                string goal_description = Console.ReadLine();
                Console.WriteLine("How many times do you want to do this goal?");
                int goal_times = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"How many bonus points should this give after completing it {goal_times} times?");
                int bonus = Int32.Parse(Console.ReadLine());                   

                Checklist checklist = new Checklist(goal_points, goal_title, goal_description, goal_times, bonus);
                goals.Add(checklist);
            }
        }
    }
}