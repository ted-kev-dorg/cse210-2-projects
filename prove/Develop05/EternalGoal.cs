class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // No additional attributes needed for EternalGoal
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded another instance of the eternal goal: {_shortName}");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}