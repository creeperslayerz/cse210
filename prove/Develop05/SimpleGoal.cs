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
        return $"{_goalType}:{base._goalName}||{base._goalDescription}||{base._goalPoints}||{base._isComplete}"; //May need to create a Setter (like SetGoalPoints)for the _isComplete to work
    }
    public override int RecordEvent()
    {
        base._isComplete = true;
        return base._goalPoints;
    }

}