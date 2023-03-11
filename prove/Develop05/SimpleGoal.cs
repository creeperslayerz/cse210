public class SimpleGoal : Goal
{
    public SimpleGoal() : base(){}
    public SimpleGoal(string name, string description, int points) : base(name, description, points){}
    
    public override int RecordEvent()
    {
        base._isComplete = true;
        return base._goalPoints;
    }

}