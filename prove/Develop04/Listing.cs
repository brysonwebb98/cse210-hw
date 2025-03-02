public class Listing : Activity
{
    private List<string> _listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _userList = new List<string>();
    public Listing()
    {
        _startingMessage = "Listing";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void GuideListing(int time)
    {
        Loading();
        Console.Clear();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nConsider the following prompt: {prompt}");
        Console.WriteLine("\nYou have a few seconds to think about it before we begin.");
        Countdown(5); 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
    
        Console.Clear();
        Console.WriteLine("Now, start listing as many items as you can.");
        Console.WriteLine($"Prompt: {prompt}");

        while (DateTime.Now < endTime)
        {
            Console.Write("Item: ");
            string userInput = Console.ReadLine();
            _userList.Add(userInput); 
        }

        Console.WriteLine($"You listed {_userList.Count} items during the activity!");
        Console.ReadKey();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _listingPrompts[rand.Next(_listingPrompts.Count)];
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("\rStarting in " + i + " ");
            Thread.Sleep(1000);
        }
    }
}
