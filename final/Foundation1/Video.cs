public class Video {
    string _title;
    string _author;
    int _length;
    List<Comment> _commentsList;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _commentsList = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _commentsList.Add(comment);
    }
    public string GetSummary() 
    {
        string summary = $"Title: {_title}\nAuthor: {_author}\nLength: {_length} minutes\nNumber of Comments: {getNumberOfComments()}\n";
        foreach (Comment comment in _commentsList)
        {
            summary += $"- {comment.getCommenterName()}: {comment.getCommenterText()}\n";
        }
        return summary;
    }
    public int getNumberOfComments() {
        return _commentsList.Count();
    }


}