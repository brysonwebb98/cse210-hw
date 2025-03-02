public class Breathing : Activity 
{

private List<string> _breathingFacts;
private string _randomFact;
    public Breathing() 
    {
        _startingMessage = "Breathing";
        _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _breathingFacts = new List<string>
        {
            "Deep breathing activates the parasympathetic nervous system, reducing stress and promoting relaxation.",
            "Proper breathing improves oxygen intake, which is vital for energy production and organ function.",
            "Focusing on your breath enhances concentration and helps clear the mind for better mental clarity.",
            "Consistent deep breathing strengthens the diaphragm and improves lung capacity, promoting better respiratory health.",
            "Slow, controlled breathing can reduce pain by calming the nervous system and distracting the mind from discomfort."
        };

        Random random = new Random();
        int index = random.Next(_breathingFacts.Count);
        _randomFact = _breathingFacts[index];
    }

    public void GuideBreathing(int time)
    {
        Console.Clear();
        Console.WriteLine("Breathing Fact of the Day:");
        Console.WriteLine($"{_randomFact}");
        Console.ReadKey();
        Loading();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        while (DateTime.Now < endTime) 
        {
            Console.WriteLine("Breathe in");
            for (int i = 5; i >= 1; i--)
            {
                if (DateTime.Now >= endTime) return;
                Console.Write($"\r{i}...");
                Thread.Sleep(1000); 
            }
            Console.Write("\r     \r"); 

            Console.WriteLine("Breathe out");
            for (int i = 5; i >= 1; i--)
            {
                if (DateTime.Now >= endTime) return;
                Console.Write($"\r{i}...");
                Thread.Sleep(1000); 
            }
            Console.Write("\r     \r"); 
        }
    }
}
