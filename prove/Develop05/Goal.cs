public class Goal
{
    private string _goalType;
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private int _userScore = 0;

    // public Goal()
    // {
    //     _userScore = 0;
    // }
    public Goal(string type, string name, string description, int points)
    {
        _goalType = type;
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
    }

    public int GetUserScore()
    {
        return _userScore;
    }

    public string CreateNewGoal()
    {
        return "";
    }
    public void ListGoals()
    {

    }
    public virtual int RecordEvent()
    //public override int RecordEvent() for derived classes
    {
        return 0;
    }
    public virtual bool IsComplete()
    {
        return true;
    }
    public void SaveGoals()
    {

    }
    public List<string> LoadGoals()
    {
        List<string> list = new List<string>
        {"",""};
        return list;
    }

}