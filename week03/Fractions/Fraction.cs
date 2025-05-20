using System.Dynamic;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _bottomNumber = 1;
        _topNumber = 1;
    }

    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public int GetTop()
    {
        return _topNumber;
    }

    public void SetTop(int top)
    {
        _topNumber = top;
    }

    public int GetBottom()
    {
        return _bottomNumber;
    }

    public void SetBottom(int bottom)
    {
        _bottomNumber = bottom;
    }

    public string GetFractionString()
    {
        string fractionString = _topNumber + "/" + _bottomNumber;
        return fractionString;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }
}