public class Reference
{
    private string _referenceBook;
    private string _referenceChapter;
    private string _referenceStartVerse;
    private string _referenceEndVerse;

    public Reference(string book, string chapter, string start, string end)
    {
        _referenceBook = book;
        _referenceChapter = chapter;
        _referenceStartVerse = start;
        _referenceEndVerse = end;
    }
    public string GetFullReference()
    {
        if (string.IsNullOrEmpty(_referenceEndVerse))
        {
            return _referenceBook + " " + _referenceChapter + ":" + _referenceStartVerse;
        } else {
            return _referenceBook + " " + _referenceChapter + ":" + _referenceStartVerse + "-" + _referenceEndVerse;
        }
    }
}