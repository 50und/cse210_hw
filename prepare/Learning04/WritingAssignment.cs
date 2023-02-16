using System;

public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment(string topic, string name, string title): base(topic, name)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string title = _title;
        return title;
    }
}