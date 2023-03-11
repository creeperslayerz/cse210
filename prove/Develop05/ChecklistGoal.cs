public class ChecklistGoal : Goal
{
    private int _goalReps;
    private int _goalRepsCompleted = 0;
    private int _bonusPoints;
    
    public ChecklistGoal() : base(){}
    public ChecklistGoal(string name, string description, int points, int reps, int bonusPoints) : base(name, description, points)
    {
        _goalReps = reps;
        _bonusPoints = bonusPoints;
    }

    public override string GetPrintString()
    {
        return $"{base._goalName} ({base._goalDescription}) Reps Completed {_goalRepsCompleted}/{_goalReps}";
    }
    
    public override int RecordEvent()
    {
        return 0; //TODO: Add logic to add goal reps to total and potentially award bonus points
    }

}