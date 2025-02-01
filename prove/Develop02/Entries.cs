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
}
