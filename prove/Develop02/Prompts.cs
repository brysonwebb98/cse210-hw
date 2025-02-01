public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What’s one thing you’re grateful for today?",
            "How do you want to feel tomorrow?",
            "What’s been on your mind lately?",
            "What did you learn today?",
            "What’s something you’ve been avoiding?",
            "What’s something you’ve accomplished recently that you're proud of?",
            "What did you do today that made you feel good?",
            "What’s something you’re looking forward to?",
            "What’s a challenge you’re currently facing, and how are you dealing with it?",
            "If you could travel anywhere right now, where would you go and why?",
            "Who in your life are you grateful for, and why?",
            "What’s something you’ve learned about yourself recently?",
            "What’s something you want to change about your routine?",
            "How would you describe your current emotional state in three words?",
            "What’s something that made you smile today?",
            "What’s a habit you want to build or break?",
            "What’s the most important goal you want to accomplish this year?",
            "What does your ideal day look like?",
            "How do you handle stress, and is there something new you want to try?",
            "If you could give advice to your younger self, what would it be?",
            "What’s one thing you love about your life right now?",
            "What’s something you’ve been putting off that you need to take action on?",
            "What’s something you want to improve in your relationships with others?",
            "What’s something you’ve been thinking about lately but haven’t talked about?",
            "What does success look like to you, and how are you working toward it?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}
