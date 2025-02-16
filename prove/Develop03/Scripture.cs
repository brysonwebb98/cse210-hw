public class Scripture 
{
    private List<string> _words;
    private List<string> _scriptureList;
    Random rand = new Random();
    private int listIndex;
    private Reference _randomReference;
    private List<Reference> _referenceList;
    private string _randomScripture;

    public Scripture()
    {
        _scriptureList = new List<string> {
            "When ye are in the service of your fellow beings ye are only in the service of your God.", 
            "But behold I will condemn you with my own mouth, for I will not speak of them.", 
            "(47)But charity is the pure love of Christ, and it endureth forever. (48)Wherefore, my beloved brethren, pray unto the Father with all the energy of heart, that ye may be filled with this love, which he hath bestowed upon all who are true followers of his Son, Jesus Christ; that ye may become the sons of God; that when he shall appear we shall be like him, for we shall see him as he is."};

        _referenceList = new List<Reference> {
            new Reference("Mosiah", "2", "17", ""),
            new Reference("Ether", "12", "37", ""),
            new Reference("Moroni", "7", "47", "48")
        };

        // Exceeding for random scriptures presented to user.
        listIndex = rand.Next(_scriptureList.Count);
        _randomScripture = _scriptureList[listIndex];
        _randomReference = _referenceList[listIndex];
        _words = _randomScripture.Split(' ').ToList();
    }

    public List<string> GetWords()
    {
        return _words;
    }

    public string GetReference()
    {
        return _randomReference.GetFullReference();
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"{GetReference()} - {string.Join(" ", _words)}");
    }

}