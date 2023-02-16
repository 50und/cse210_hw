using System;

public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public Assignment(string topic, string studentName)
    {
        _topic = topic;
        _studentName = studentName;
    }
    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }
}