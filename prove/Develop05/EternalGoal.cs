public class EternalGoal : Goal
{
    public EternalGoal() : base(){}
    public EternalGoal(string name, string description, int points) : base(name, description, points){}

    public override int RecordEvent()
    {
        return base._goalPoints;
    }
    
}