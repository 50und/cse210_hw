//Person
// - name(s)
// - birth data(s)
// - gender
class Person
{
    string name;
    string birth;
    string gender;
    List<string> names;

    public string GetGender()
    {
        return this.gender;
    }
}

class Program
{
    static void Main(string[] args)
    {

        //Data
        List<string> items = new List<string>();
        List<float> prices = new List<float>();

        DisplayMenu();
        bool done = false;
        while (!done)
        {
            DisplayMenu();
            int choice = GetChoice();
            /*
            switch (choice)
            {
                case 1:
                    AddItem(items, prices);
                    break;
                case 2:
                    Display(items, prices);
                    break;
                case 5:
                    done
            }
            */



            if (choice ==1)
            {
                AddItem(items, prices);
            }
            if (choice == 2)
            {
                Display(items, prices);
            }
            if (choice == 5)
            {
                done = true;
            }


        }

    }
    static void DisplayMenu()
    {
        System.Console.Writeline("1) Add Item");
        System.Console.Writeline("2) Display");
        System.Console.Writeline("3) Total");
        System.Console.Writeline("4) remove");
        System.Console.Writeline("5) quit");
    }

    static int GetChoice()
    {
        System.Console.Write("Enter Choice: ");
        string choice = Console.ReadLine();
        int answer = int.Parse(choice);
        return answer;
    }

    static void AddItem(List<string> items, List<float> prices)
    {
        System.Console.Write("Enter Item: ");
        string item = Console.ReadLine();

        System.Console.Write("Enter Price: ");
        string price = Console.ReadLine();
        float priceAmount = float.Parse(price);

        item.Add(item);
        prices.Add(priceAmount);
        
    }

    static void Display(List<string> items, List<float> prices)
    {
        System.Console.WriteLine("DISPLAY ITEMS");
        for (int i = 0; i< item.Count; i++)
        {
            System.Console.WriteLine($"{items[i]}: {prices[i]}");
        }
        System.Console.WriteLine("");
    }
}