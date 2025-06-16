using System;
public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(string date, int length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62; // Distance in miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60; // Speed in mph
    }

    public override double GetPace()
    {
        return _length / GetDistance(); // Pace in minutes per mile
    }
}