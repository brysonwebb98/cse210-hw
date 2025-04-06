public class Activity
{
    private string _date;
    private int _lengthInMinutes;
    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }
    public string GetDate() => _date;
    public int GetLengthInMinutes() => _lengthInMinutes;
    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;
    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name}\nActivity ({_lengthInMinutes} min): \nDistance {GetDistance():0.0} km \nSpeed {GetSpeed():0.0} kph, \nPace: {GetPace():0.0} min per km";
    }
}