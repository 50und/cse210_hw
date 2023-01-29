using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Entry entry = new Entry();

        char choice = '0';
        while (choice != '5')
        {
            System.Console.WriteLine("Options: ");
            System.Console.WriteLine("1) Load Journal: ");
            System.Console.WriteLine("2) Display Journal: ");
            System.Console.WriteLine("3) Save Journal: ");
            System.Console.WriteLine("4) Add Entry: ");
            System.Console.WriteLine("5) Quit: ");
            choice = Console.ReadKey().KeyChar;
            switch (choice)
            {
                case '1':
                    System.Console.WriteLine();
                    journal.Load();
                    break;
                case '2':
                    System.Console.WriteLine();                
                    journal.Display();
                    break;
                case '3':
                    System.Console.WriteLine();
                    journal.Save();
                    break;
                case '4':
                    System.Console.WriteLine();
                    journal.AddEntry();
                    break;
            }
        }
    }
} 
