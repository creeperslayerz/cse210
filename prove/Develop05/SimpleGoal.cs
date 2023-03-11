public class SimpleGoal : Goal
{
    public SimpleGoal() : base(){}
    public SimpleGoal(string name, string description, int points) : base(name, description)
    {
        base._goalPoints = points;
    }
    public override int RecordEvent()
    {
        return 0;
    }

}