using System;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment(string name, string topic, string section, string problems) : base(topic, name)
    {
        _problems = problems;
        _textbookSection = section;
    }
    public string GetHomeworkList()
    {
        string homework = $"{_textbookSection}, {_problems}";
        return homework;
    }
}