class ChecklistGoal : Goal
{
    public int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"You recorded another instance of the checklist goal: {_shortName}");

        if (_amountCompleted == _target)
        {
            _points += _bonus;
            Console.WriteLine($"Congratulations! You achieved the target for {_shortName} and earned a bonus of {_bonus} points!");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[{_amountCompleted}/{_target}] {_shortName} ({_description}) Bonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}