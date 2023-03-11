public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    protected int _goalPoints = 0;
    protected bool _isComplete = false; 

    public Goal() 
    {
        _goalName = "";
        _goalDescription = "";
    }
    
    public Goal(string name, string description) //Can probably get rid of goalType?? or all of the parameters??
    {
        _goalName = name;
        _goalDescription = description;
    }

    public abstract int RecordEvent();
    //public override int RecordEvent() for derived classes
    
    public bool IsComplete()
    {
        return _isComplete;
    }

}