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
    public Goal(string goal)
    {
        SetStringRepresentation(goal);
    } 

    

    public abstract bool GetCompleted();

    public abstract void SetStringRepresentation(string rep);

    public abstract string GetStringRepresentation();

    public void Save(string filename)
    {
        using (StreamWriter _outputfile = new StreamWriter(filename))
        {
            _outputfile.Write(GetStringRepresentation());
        }
    }










}