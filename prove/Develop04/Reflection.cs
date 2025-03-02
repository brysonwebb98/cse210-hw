public class Reflection : Activity
{
    private List<string> _reflectionPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection()
    {
        _startingMessage = "Reflection";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void GuideReflection(int time)
    {
        Loading();
        Console.Clear();
        Console.WriteLine("\nConsider the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Now, reflect on the following questions:");
        Console.WriteLine("You will have time to think after each question.\n");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        Console.Clear();
        while (DateTime.Now < endTime)
        {   
            for (int i = 0; i < _reflectionQuestions.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}: {_reflectionQuestions[i]}");
                Spinner(3); 
                if (DateTime.Now >= endTime) return;
            }
        }
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _reflectionPrompts[rand.Next(_reflectionPrompts.Count)];
    }

    private void Spinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");      
            Thread.Sleep(350);       
            Console.Write("\b");     
            Console.Write("-");      
            Thread.Sleep(350);       
            Console.Write("\b");     
            Console.Write("\\");     
            Thread.Sleep(350);       
            Console.Write("\b");     
            Console.Write("|");      
            Thread.Sleep(350);       
            Console.Write("\b");     
            Console.Write("-");      
            Thread.Sleep(350); 
            Console.Write("\b");
        }
        Console.WriteLine();
    }
}