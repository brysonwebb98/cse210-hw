public class Event {
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle() => _title;
    public string GetDescription() => _description;
    public string GetDate() => _date;
    public string GetTime() => _time;
    public Address GetAddress() => _address;

    public string GetStandardDetails()
    {
        return $"{GetTitle()}\n{GetDescription()}\nDate: {GetDate()} Time: {GetTime()}\nLocation: {GetAddress().GetFullAddress()}";
    }
}