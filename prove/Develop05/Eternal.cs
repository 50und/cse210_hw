using System;

public class Eternal: Goal
{
    public Eternal(int points, string title, string description): base(points, title, description)
    {
        _points = points;
        _title = title;
        _description = description;
    }

    public Eternal(string stringRep): base(stringRep)
    {
    }

    public override void SetStringRepresentation(string rep)
    {
        string [] attributes = rep.Split("|");
        _title = attributes[0];
        _description = attributes[1];
        _points = Int32.Parse(attributes[2]);
    }

    public override string GetStringRepresentation()
    {
        string stringRep = $"Eternal:{_title}|{_description}|{_points}";
        return stringRep;
    }

    public override bool GetCompleted()
    {
        return false;
    }

}