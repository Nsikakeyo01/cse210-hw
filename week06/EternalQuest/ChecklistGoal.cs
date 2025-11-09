public class ChecklistGoal : Goal
{
    private int _completedCount;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int completed = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _completedCount = completed;
    }

    public override int RecordEvent()
    {
        _completedCount++;
        return _completedCount == _target ? _points + _bonus : _points;
    }

    public override bool IsComplete() => _completedCount >= _target;

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[✔]" : "[ ]";
        return $"{status} {_name} — {_description} (Progress: {_completedCount}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_target},{_bonus},{_completedCount}";
    }
}
