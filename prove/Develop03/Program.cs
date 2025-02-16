using System;
using System.Reflection;

class Program
{
    private static bool isRunning = true;

    static void Main(string[] args)
    {
        Scripture s = new Scripture();
        Word wordManager = new Word(s.GetWords());
        Console.Clear();
        
        while (isRunning)
        {
            Console.WriteLine(s.GetReference());
            wordManager.DisplayScripture();
            wordManager.HideRandomWord();
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Thank you for coming! Have a great day!");
                Console.ReadLine();
                isRunning = false;
            } else if (wordManager.AreAllWordsHidden())
            {
                Console.Clear();
                // Quiz to Exceed :)
                Console.WriteLine("Thank you for reviewing. For extra points what was the scripture reference?");
                string quiz = Console.ReadLine();

                Console.Clear();
                
                if (quiz == s.GetReference())
                {
                    Console.WriteLine($"Great job! The scripture is {s.GetReference()}! Have a great day!");
                } else 
                {
                    Console.WriteLine($"Sorry the reference is actually: {s.GetReference()}! Study some more!");
                }
                Console.ReadKey();
                isRunning = false;
            }
            Console.Clear();
        }
    }
}