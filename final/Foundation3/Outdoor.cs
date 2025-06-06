class Outdoor : Event
{
    private string _weather;
    
    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }
    public string GetOutdoorFull()
    {
        return $"{GetStandardDetails()}\nWeather Broadcast: {_weather}";
    }
    public string GetShortOutdoorDescription()
    {
        return $"Outdoor Gathering: {GetTitle()} on {GetDate()}!";
    }
}