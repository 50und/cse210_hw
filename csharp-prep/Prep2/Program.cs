using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the grade?");
        int grade = Int32.Parse(System.Console.ReadLine());
        string letter = "";
        if (grade>=90)
        {
            letter = "A";
        }
        else if (grade>=80)
        {
            letter = "B";
        }
        else if (grade>=70)
        {
            letter = "C";
        }
        else if (grade>=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        string plusMinus = "";
        if (grade % 10 >= 7)
        {
            plusMinus = "+";
        }
        else if (grade % 10 <=3)
        {
            plusMinus = "-";
        }
        else
        {
            plusMinus = "";
        }
        System.Console.WriteLine($"Student's Grade is {letter}{plusMinus}");
    }
}