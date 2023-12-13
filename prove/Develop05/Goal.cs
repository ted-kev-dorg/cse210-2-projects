abstract class Goal
{
    protected string _shortName;
    protected string _description;
    public int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent() { }
    public virtual bool IsComplete() { return false; }
    public virtual string GetDetailsString()
    {
        return $"[{(_points > 0 ? "X" : " ")}] {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
}