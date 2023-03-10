using System;

public class Checklist: Goal
{
    private int _goalTimes = 0;
    private int _completedTimes = 0;

    private int _bonusPoints = 0;

    public Checklist(int points, string title, string description, int goalTimes, int completedTimes, int bonus): base(points, title, description)
    {
        _points = points;
        _title = title;
        _description = description;
        _goalTimes = goalTimes;
        _completedTimes = completedTimes;
        _bonusPoints = bonus;

    }

}