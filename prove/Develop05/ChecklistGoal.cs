public class ChecklistGoal : Goal
{
    private int _goalReps;
    private int _goalRepsCompleted = 0;
    private int _bonusPoints;
    
    public ChecklistGoal(){}

    public void SetGoalReps(int goalReps)
    {
        _goalReps = goalReps;
    }
    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }
    public override int RecordEvent()
    {
        return 0;
    }

}