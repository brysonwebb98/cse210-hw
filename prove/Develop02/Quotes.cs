public class QuoteGenerator
{
    private List<string> _quotes;

    public QuoteGenerator()
    {
        _quotes = new List<string>
        {
            "The only way to do great work is to love what you do. Steve Jobs",
            "Success is not the key to happiness. Happiness is the key to success. Albert Schweitzer",
            "Believe you can and you're halfway there. Theodore Roosevelt",
            "Don't watch the clock; do what it does. Keep going. Sam Levenson",
            "You miss 100% of the shots you don't take. Wayne Gretzky"
        };
    }

    public string GetRandomQuote()
    {
        Random random = new Random();
        int randomIndex = random.Next(_quotes.Count);
        return _quotes[randomIndex];
    }
}
