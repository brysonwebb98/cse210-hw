public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Content { get; set; }
    public Entry(string date, string prompt, string content)
    {
        Date = date;
        Prompt = prompt;
        Content = content;
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Content: {Content}");
        Console.WriteLine();
    }

    public void SaveToFile(StreamWriter writer)
    {
        writer.WriteLine($"{Date}|{Prompt}|{Content}");
    }
    public static Entry FromFileLine(string line)
    {
        var parts = line.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[0], parts[1], parts[2]);
        }
        return null;
    }
}
