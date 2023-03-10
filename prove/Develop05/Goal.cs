using System;

public abstract class Goal
{
    protected int _points = 0;
    protected string _title = "";
    protected string _description = "";

    public Goal(int points, string title, string description)
    {
        _points = points;
        _title = title;
        _description = description;

    }
    public Goal()
    {
        SetStringRepresentation();
    }

    public abstract bool GetCompleted();

    public abstract string SetStringRepresentation(string rep);






}