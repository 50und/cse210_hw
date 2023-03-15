using System;

public class Simple: Goal
{
    private string _completed = "";

    public Simple(int points, string title, string description): base(points, title, description)
    {
        _points = points;
        _title = title;
        _description = description;
    }

    public Simple(string stringRep): base(stringRep)
    {
    }

    public override void SetStringRepresentation(string rep)
    {
        string [] attributes = rep.Split("|");
        string [] title = attributes[0].Split("]");
        _completed = title[0].Trim(new char [] {'['});
        _title = title[1];
        _description = attributes[1];
        _points = Int32.Parse(attributes[2]);       
    }

    public override string GetStringRepresentation()
    {
        string stringRep = $"Simple:[{_completed}]{_title}|{_description}|{_points}";
        return stringRep;
    }

    public void SetCompleted()
    {
        _completed = "X";
    }

    public override string GetCompleted()
    {
        return _completed;
    }

    public override int DoIt()
    {
        SetCompleted();
        return _points;
    }

}