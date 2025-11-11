using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string Date => _date;
    public int Minutes => _minutes;

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Summary method uses polymorphism
    public string GetSummary()
    {
        return $"{Date} {GetType().Name} ({Minutes} min) - Distance: {GetDistance():0.00}, " +
               $"Speed: {GetSpeed():0.00}, Pace: {GetPace():0.00} min per unit";
    }
}
