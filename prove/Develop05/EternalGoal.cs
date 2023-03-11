public class EternalGoal : Goal
{
    private string _goalType = "Eternal Goal";

    public EternalGoal() : base(){}
    public EternalGoal(string name, string description, int points) : base(name, description, points){}

    public void SetGoalPoints(int points)
    {
        base._goalPoints = points;
    }
    
    public override string GetSaveString()
    {
        return $"{_goalType}:{base._goalName}||{base._goalDescription}||{base._goalPoints}";
    }
    public override int RecordEvent()
    {
        return base._goalPoints;
    }
    
}