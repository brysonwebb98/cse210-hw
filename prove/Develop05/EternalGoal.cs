class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) {}
    public override void RecordEvent(ref int totalScore)
    {
        totalScore += Points;
        Console.WriteLine($"Congrats you added {Points} points! This is an eternal goal continue to strive and repeat often!");
    }
    public override string GetStatus() => "[∞]";
    public override string ToString() => $"EternalGoal:{Name},{Description},{Points}";
}
