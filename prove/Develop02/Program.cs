using System;
using System.Threading.Tasks.Dataflow;
public partial class Program
{
    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Hello and welcome to your Journal!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("Enter your choice (1-5): ");
    }
    static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        string content = Console.ReadLine();
        Console.WriteLine("Entry added to list. Make sure to save entries for today!");
        Console.ReadKey();
        Entry newEntry = new Entry(DateTime.Now.ToString("yyyy-MM-dd h:mm tt"), prompt, content);
        journal.AddEntry(newEntry);
    }
    static void DisplayJournal(Journal journal)
    {
        journal.DisplayAllEntries();
    }
    static void LoadJournal(Journal journal)
    {
    Console.WriteLine("If you would like to see your Journal, please enter the file name:");
    string filePath = Console.ReadLine();
    
    if (!File.Exists(filePath))
    {
        Console.WriteLine("This file does not exist. Please check the file name again!");
    }
    else
    {
        if (journal.LoadFromFile(filePath))
        {
            Console.Clear();
            Console.WriteLine("Journal loaded successfully!");
            string journalContent = File.ReadAllText(filePath);
            Console.WriteLine(journalContent);
        }
        else
        {
            Console.WriteLine("Error loading journal from file.");
        }
    }
    Console.ReadKey();
    }
    static void SaveJournal(Journal journal)
    {
    Console.WriteLine("What is the filename?");
    string filePath = Console.ReadLine();

    if (File.Exists(filePath))
    {
        journal.SaveToFile(filePath);
        Console.WriteLine("Successfully Saved to existing file!");
    }
    else
    {
        Console.WriteLine("File does not exist. A new file will be created.");
        journal.SaveToFile(filePath);
        Console.WriteLine("Successfully Saved to new file!");
    }

    Console.ReadKey();
    }
    static void ExitProgram()
    {
        Console.WriteLine("Thank you for writing in your journal today! Below is the daily quote for you!");
        QuoteGenerator quoteGenerator = new QuoteGenerator();
        string dailyQuote = quoteGenerator.GetRandomQuote();

        Console.WriteLine(dailyQuote);
    }
    static void Main(string[] args)
    {
        bool quit = false;
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (!quit)
        {
            DisplayMenu();

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    WriteEntry(journal, promptGenerator);
                    break;
                case "2":
                    DisplayJournal(journal);
                    break;
                case "3":
                    LoadJournal(journal);
                    break;
                case "4":
                    SaveJournal(journal);
                    break;
                case "5":
                    ExitProgram();
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid input! Press any key to try again!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
