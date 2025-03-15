class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }
    public override void RecordEvent(ref int totalScore)
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            totalScore += Points;
            Console.WriteLine($"Congrats you added {Points} points!");
        }
    }
    public override string GetStatus() => _isCompleted ? "[X]" : "[ ]";
    public override string ToString() => $"SimpleGoal:{Name},{Description},{Points},{_isCompleted}";
}
