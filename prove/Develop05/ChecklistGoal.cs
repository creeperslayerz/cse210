public class ChecklistGoal : Goal
{
    private string _goalType = "Checklist Goal";
    private int _goalReps;
    private int _goalRepsCompleted = 0;
    private int _bonusPoints;
    
    public ChecklistGoal() : base(){}
    public ChecklistGoal(string name, string description, int points, int reps, int bonusPoints) : base(name, description, points)
    {
        _goalReps = reps;
        _bonusPoints = bonusPoints;
    }

    public void SetGoalPoints(int points)
    {
        base._goalPoints = points;
    }

    public override string GetPrintString()
    {
        return $"{base._goalName} ({base._goalDescription}) Reps Completed {_goalRepsCompleted}/{_goalReps}";
    }
    public override string GetSaveString()
    {
        return $"{_goalType}||{base._goalName}||{base._goalDescription}||{base._goalPoints}||{_isComplete}||{_bonusPoints}||{_goalReps}||{_goalRepsCompleted}";
    }
    public override void SetGoalParts(string[] parts)
    {
        _goalName = parts[1];
        _goalDescription = parts[2];
        _goalPoints = int.Parse(parts[3]);
        _isComplete = bool.Parse(parts[4]);
        _bonusPoints = int.Parse(parts[5]);
        _goalReps = int.Parse(parts[6]);
        _goalRepsCompleted = int.Parse(parts[7]);
    }
    public override int RecordEventByType()
    {
        return 0; //TODO: Add logic to add goal reps to total and potentially award bonus points
    }

}