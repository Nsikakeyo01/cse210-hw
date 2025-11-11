using System;

public class Swimming : Activity
{
    private int _laps; // number of laps
    private const double LapLength = 50; // meters

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * LapLength) / 1000 * 0.62; // convert meters to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60; // mph
    }

    public override double GetPace()
    {
        return Minutes / GetDistance(); // min per mile
    }
}
