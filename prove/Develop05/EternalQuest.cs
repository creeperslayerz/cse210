using System.IO;

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

        while(choice != "6") //TODO: Add logic for menu options 4 and 5
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
            // if(choice == "4")
            // {
            //     LoadGoals();
            // }
        }
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
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        
        if(goalChoice == "1")
        {
            Console.Write("What is the amount of point associated with this goal? ");
            string pointsAsString = Console.ReadLine();
            int goalPoints = int.Parse(pointsAsString);
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            simpleGoal.SetGoalPoints(goalPoints);
            _goalsList.Add(simpleGoal);   
        }
        if(goalChoice == "2")
        {
            Console.Write("What is the amount of point associated with each occurence of this goal? ");
            string pointsAsString = Console.ReadLine();
            int goalPoints = int.Parse(pointsAsString);
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints); 
            eternalGoal.SetGoalPoints(goalPoints);
            _goalsList.Add(eternalGoal);            
        }
        else if(goalChoice == "3")
        {
            Console.Write("What is the amount of point associated with each repetition of this goal? ");
            string pointsAsString = Console.ReadLine();
            int goalPoints = int.Parse(pointsAsString);
            Console.Write("How many repetitions will it take to complete this goal? ");
            string goalRepsAsString = Console.ReadLine();
            int goalReps = int.Parse(goalRepsAsString);
            Console.Write("What are the bonus points for completing this goal? ");
            string bonusPointsAsString = Console.ReadLine();
            int bonusPoints = int.Parse(bonusPointsAsString);
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalReps, bonusPoints);
            checklistGoal.SetGoalPoints(goalPoints);
            _goalsList.Add(checklistGoal); 
        } 
    }
    public void ListGoals() //TODO: Incoporate IsComplete() inside []
    {
        Console.WriteLine("The goals are:");
        int goalNumber = 0;
        foreach(Goal goal in _goalsList) 
        {
            goalNumber += 1;
            Console.WriteLine($"{goalNumber}. [] {goal.GetPrintString()}");
        }
    } 
    public void SaveGoals() 
    {
        Console.WriteLine("What file name would you like to save it to? "); //"goals.txt"
        string fileName = Console.ReadLine();

        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Goal goal in _goalsList)
            {
                outputFile.WriteLine($"{goal.GetSaveString()}");
            }            
        }
    }
    // public void LoadGoals() //Does LoadGoals() need to be in each derived class like RecordEvent()??
    // {
    //     Console.WriteLine("What file name would you like to load from? "); //"goals.txt"
    //     string fileName = Console.ReadLine();
    
    //     _goalsList.Clear();
        
    //     string[] lines = System.IO.File.ReadAllLines(fileName);
        
    //     foreach(string line in lines)
    //     {
    //         string[] parts = line.Split("||");

    //         Goal goal = new Goal();
            
    //         goal._goalName = parts[0];
    //         goal._goalDescription = parts[1];
    //         goal._goalPoints = parts[2];

    //         _goalsList.Add(goal);
    //     }
    // }     
}