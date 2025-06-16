using System;
public class CyclingActivity : Activity
{
    private double _distance;

    public CyclingActivity(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60; // Speed in mph
    }

    public override double GetPace()
    {
        return _length / _distance; // Pace in minutes per mile
    }
}