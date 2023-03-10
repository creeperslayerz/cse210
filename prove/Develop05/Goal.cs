public class Goal
{
    private string _goalType;
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private int _userScore = 0;
    private int _goalReps; //Used in checklist goal
    private int _goalRepsCompleted = 0; //Used in checklist goal
    private int _bonusPoints; //Used in checklist goal
    private List<string> _goalsList = new List<string>();
    private bool _isComplete = false; //Used in simple goal

    public Goal() 
    {
        _goalType = "";
        _goalName = "";
        _goalDescription = "";
        _goalPoints = 0;
    }
    
    // public Goal(string type, string name, string description, int points) //Can probably get rid of goalType?? or all of the parameters??
    // {
    //     _goalType = type;
    //     _goalName = name;
    //     _goalDescription = description;
    //     _goalPoints = points;
    // }

    public int GetUserScore()
    {
        return _userScore;
    }

    public void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalChoice = Console.ReadLine();
        
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of point associated with this goal? ");
        string pointsAsString = Console.ReadLine();
        _goalPoints = int.Parse(pointsAsString);
        
        if(goalChoice == "1")
        {
            _goalType = "Simple Goal:";
            _goalsList.Add($"{_goalType}||{_goalName}||{_goalDescription}||{_goalPoints}||{_isComplete}");
        }
        if(goalChoice == "2")
        {
            _goalType = "Eternal Goal:";
            _goalsList.Add($"{_goalType}||{_goalName}||{_goalDescription}||{_goalPoints}");
        }
        else if(goalChoice == "3")
        {
            _goalType = "Checklist Goal:";
            Console.Write("How many repetitions will it take to complete this goal? ");
            string goalRepsAsString = Console.ReadLine();
            _goalReps = int.Parse(goalRepsAsString);
            Console.Write("What are the bonus points for completing this goal? ");
            string bonusPointsAsString = Console.ReadLine();
            _bonusPoints = int.Parse(bonusPointsAsString);
            _goalsList.Add($"{_goalType}||{_goalName}||{_goalDescription}||{_goalPoints}||{_bonusPoints}||{_goalReps}||{_goalRepsCompleted}");
        }       
    }
    public void ListGoals()
    {
        foreach(string goal in _goalsList) //TODO: Split _goalsList and display in different format
        {
            Console.WriteLine(goal);
        }
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