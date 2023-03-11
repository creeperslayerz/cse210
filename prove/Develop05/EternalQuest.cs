public class EternalQuest
{
    private int userScore = 0;
    private List<Goal> _goalsList = new List<Goal>();

    public EternalQuest()
    {
        mainMenu();
    }

    public void mainMenu()
    {     
        string choice = "-1";

        while(choice != "6") //TODO: Add logic for menu option 5
        {
            Console.WriteLine();
            Console.WriteLine($"You have {userScore} points."); 
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.WriteLine();
            if(choice == "1")
            {
                CreateNewGoal();
            }
            if(choice == "2")
            {
                ListGoals();
            }
            if(choice == "3")
            {
                SaveGoals();
            }
            if(choice == "4")
            {
                LoadGoals();
            }
        }
    }  
    public void CreateNewGoal() //TODO: Get option 3 to work for Checklist Goals
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalChoice = Console.ReadLine();
        
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        
        if(goalChoice == "1")
        {
            Console.Write("What is the amount of point associated with this goal? ");
            string pointsAsString = Console.ReadLine();
            int goalPoints = int.Parse(pointsAsString);
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goalsList.Add(simpleGoal);   
        }
        if(goalChoice == "2")
        {
            Console.Write("What is the amount of point associated with each occurence of this goal? ");
            string pointsAsString = Console.ReadLine();
            int goalPoints = int.Parse(pointsAsString);
            EternalGoal eternalGoal = new EternalGoal(); //TODO: Add arguments for EternalGoal()
            _goalsList.Add(eternalGoal);            
        }
        else if(goalChoice == "3")
        {
            // ChecklistGoal checklistGoal = new ChecklistGoal();
            // _goalType = "Checklist Goal:";
            // Console.Write("How many repetitions will it take to complete this goal? ");
            // string goalRepsAsString = Console.ReadLine();
            // _goalReps = int.Parse(goalRepsAsString);
            // Console.Write("What are the bonus points for completing this goal? ");
            // string bonusPointsAsString = Console.ReadLine();
            // _bonusPoints = int.Parse(bonusPointsAsString);
            // _goalsList.Add($"{_goalType}||{_goalName}||{_goalDescription}||{_goalPoints}||{_bonusPoints}||{_goalReps}||{_goalRepsCompleted}");
        } 
    }
    public void ListGoals() //TODO: fix logic and format of ListGoals() to match video (use GetPrintString()??)
    {
        foreach(Goal goal in _goalsList) 
        {
            Console.WriteLine(goal);
        }
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