class Word
{
    private List<string> _words;

    public Word(List<string> words)
    {
        _words = words;
    }
    public void HideRandomWord()
    {
        Random rand = new Random();
        List<int> availableIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i] != "___")
            {
                availableIndexes.Add(i);
            }
        }

        if (availableIndexes.Count > 0)
        {
            int randomIndex = rand.Next(availableIndexes.Count);
            _words[availableIndexes[randomIndex]] = "___";
        }
    }
    public void DisplayScripture()
    {
        Console.WriteLine(string.Join(" ", _words));
    }
    public bool AreAllWordsHidden()
    {
        return !_words.Any(word => word != "___");
    }
}