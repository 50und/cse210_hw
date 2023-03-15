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
        string [] title = attributes[0].Split("]");
        _title = title[1];
        _description = attributes[1];
        _points = Int32.Parse(attributes[2]);
    }

    public override string GetStringRepresentation()
    {
        string stringRep = $"Eternal:[{GetCompleted()}]{_title}|{_description}|{_points}";
        return stringRep;
    }

    public override string GetCompleted()
    {
        return "";
    }

    public override int DoIt()
    {
        return _points;
    }
}