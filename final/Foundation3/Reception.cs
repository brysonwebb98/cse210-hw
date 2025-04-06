class Reception : Event
{
    private string _rsvpEmail;
    
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public string GetReceptionFull()
    {
        return $"{GetStandardDetails()}\nEmail: {_rsvpEmail}";
    }
    public string GetShortReceptionDescription()
    {
        return $"Reception: {GetTitle()} on {GetDate()}!";
    }
}