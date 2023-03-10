public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints = 0;
    protected bool _isComplete = false; 

    public Goal() 
    {
        _goalName = "";
        _goalDescription = "";
    }
    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _goalDescription = description;
    }

    public abstract void SetGoalParts(string[] parts);

    public virtual string GetPrintString()
    {
        return $"{_goalName} ({_goalDescription})";
    }
    public abstract string GetSaveString(); 
    
    public abstract int RecordEventByType();
    
    public bool IsComplete()
    {
        return _isComplete;
    }
}