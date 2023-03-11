public class SimpleGoal : Goal
{
    public SimpleGoal() : base(){}
    public SimpleGoal(string name, string description, int points) : base(name, description)
    {
        base._goalPoints = points;
    }
    public override int RecordEvent()
    {
        base._isComplete = true;
        return base._goalPoints;
    }

}