public class SimpleGoal : Goal
{
    private string _goalType = "Simple Goal";

    public SimpleGoal() : base(){}
    public SimpleGoal(string name, string description, int points) : base(name, description, points){}

    public void SetGoalPoints(int points)
    {
        base._goalPoints = points;
    }
    public override string GetSaveString()
    {
        return $"{_goalType}||{base._goalName}||{base._goalDescription}||{base._goalPoints}||{base._isComplete}"; //May need to create a Setter (like SetGoalPoints)for the _isComplete to work
    }
    public override void SetGoalParts(string[] parts)
    {
        _goalName = parts[1];
        _goalDescription = parts[2];
        _goalPoints = int.Parse(parts[3]);
        _isComplete = bool.Parse(parts[4]);
    }
    public override int RecordEventByType()
    {
        base._isComplete = true;
        return base._goalPoints;
    }

}