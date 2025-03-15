class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent(ref int totalScore)
    {
        if (_timesCompleted < _target)
        {
            _timesCompleted++;
            totalScore += Points;
            Console.WriteLine($"Congrats you added {Points} points!");
            if (_timesCompleted == _target) totalScore += _bonus;
        }
    }
    public override string GetStatus() => $"[{_timesCompleted}/{_target}]";
    public override string ToString() => $"ChecklistGoal:{Name},{Description},{Points},{_timesCompleted},{_target},{_bonus}";
}
