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

    public Checklist(string stringRep): base(stringRep)
    {
    }


    public override void SetStringRepresentation(string rep)
    {
        string [] attributes = rep.Split("|");
        _title = attributes[0];
        _description = attributes[1];
        _points = Int32.Parse(attributes[2]);
        _goalTimes = Int32.Parse(attributes[3]);
        _completedTimes = Int32.Parse(attributes[4]);
        _bonusPoints = Int32.Parse(attributes[5]);
    }

    public override string GetStringRepresentation()
    {
        string stringRep = $"Checklist:{_title}|{_description}|{_points}|{_goalTimes}|{_completedTimes}|{_bonusPoints}";
        return stringRep;
    }

    


}