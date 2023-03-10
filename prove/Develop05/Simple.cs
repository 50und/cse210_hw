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


}