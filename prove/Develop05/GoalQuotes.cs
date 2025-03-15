class GoalQuotes
{
    private static string[] quotes = 
    {
        "A goal without a plan is just a wish. - Antoine de Saint-Exupéry",
        "Success is the sum of small efforts, repeated day in and day out. - Robert Collier",
        "Setting goals is the first step in turning the invisible into the visible. - Tony Robbins",
        "The journey of a thousand miles begins with one step. - Lao Tzu",
        "You are never too old to set another goal or to dream a new dream. - C.S. Lewis"
    };
    private static Random random = new Random();
    public static void DisplayRandomQuote()
    {
        int index = random.Next(quotes.Length);
        Console.WriteLine("\nRemember: " + quotes[index]);
    }
}