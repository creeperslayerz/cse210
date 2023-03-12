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
        return $"{_goalType}||{base._goalName}||{base._goalDescription}||{base._goalPoints}";
    }
    public override void SetGoalParts(string[] parts)
    {
        _goalName = parts[1];
        _goalDescription = parts[2];
        _goalPoints = int.Parse(parts[3]);
    }
    public override int RecordEventByType()
    {
        return base._goalPoints;
    }
    
}