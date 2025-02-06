public class Fraction 
{
    private int _top;
    private int _bottom;

    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }

    public int getTop()
    {
        return _top;
    }

    

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"The Fraction is {_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top/_bottom;
    }
    
}