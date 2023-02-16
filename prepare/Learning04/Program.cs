using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "Samuel Bennett";
        string topic = "Multiplication";
        Assignment assignment = new Assignment(topic, name);
        Console.WriteLine(assignment.GetSummary());

        string mname = "Roberto Rodriguez";
        string mtopic = "Fractions";
        string section = "Section 7.3";
        string problems = "8-19";

        MathAssignment math = new MathAssignment(mname, mtopic, section, problems);
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        string wname = "Mary Waters";
        string wtopic = "European History";
        string lesson = "The Causes of World War II by Mary Waters";

        WritingAssignment writing = new WritingAssignment(wtopic, wname, lesson);
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());

    }
}