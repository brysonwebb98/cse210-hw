public class Comment {
    string _commenterName;
    string _commenterText;
    public Comment(string name, string text) {
        _commenterName = name;
        _commenterText = text;
    }
    public string getCommenterName()
    {
        return _commenterName;
    }
    public string getCommenterText()
    {
        return _commenterText;
    }
}