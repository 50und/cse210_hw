using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> text = new List<string>{"Come unto me, all ye that labour and are heavy laden, and I will give you rest.",
        "Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls.",
        "For my yoke is easy, and my burden is light."};

        Scripture scripture = new Scripture(text);


        while (!scripture.IsAllHidden())
        {
            scripture.Display();
            System.Console.WriteLine();
            System.Console.WriteLine("Press ENTER to hide 4 words");
            System.Console.WriteLine("Type Quit to exit");
            string action = System.Console.ReadLine();
            if (action == "Quit")
            {
                break;
            }
            else
            {
                scripture.HideWords();
            }      
        }

    }
}