using System;

public class Simple: Goal
{
    private bool _completed = false;

    public Simple(int points, string title, string description): base(points, title, description)
    {
        _points =points;
        _title = title;
        _description = description;
    }

    public Simple(string stringRep): base(stringRep)
    {
    }

    public override void SetStringRepresentation(string rep)
    {
        string [] attributes = rep.Split("|");
        _title = attributes[0];
        _description = attributes[1];
        _points = Int32.Parse(attributes[2]);
        _completed = Boolean.Parse(attributes[3]);
    }

    public override string GetStringRepresentation()
    {
        string stringRep = $"Simple:{_title}|{_description}|{_points}|{_completed}";
        return stringRep;
    }

    public void SetCompleted()
    {
        _completed = true;
    }

    public override bool GetCompleted()
    {
        return _completed;
    }

}