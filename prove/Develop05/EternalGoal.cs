public class EternalGoal : Goal
{
    public override int RecordEvent()
    {
        return base._goalPoints;
    }
    
}