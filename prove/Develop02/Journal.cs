public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAllEntries()
    {
        int numEntries = 1;
        foreach (var entry in _entries)
        {
            Console.WriteLine();
            Console.WriteLine($"Entry Number {numEntries}:");
            entry.DisplayEntry();
            numEntries += 1;
        }
        Console.ReadKey();
    }

    public bool SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename, append: true))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry.Date}|Prompt: {entry.Prompt}|Journal: {entry.Content}|");
                }
            }

            _entries.Clear();

            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool LoadFromFile(string filename)
    {
        try
        {
            var lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    var entry = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(entry);
                }
            }
            return true;
        }
        catch
        {
            return false;
        }
    }
}
