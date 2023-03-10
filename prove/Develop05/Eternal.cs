using System;

public class Eternal: Goal
{
    public Eternal(int points, string title, string description): base(points, title, description)
    {
        _points = points;
        _title = title;
        _description = description;
    }
}