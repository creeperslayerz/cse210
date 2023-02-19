public class Activity
{
    // private string _activityName;
    private int _activityDuration;

    // public Activity()
    // {
    //     // _activityName = activityName;
    //     // _activityDescription = activityDescription;
    //     // _activityDuration = activityDuration;
    // }

    public int GetActivityDuration()
    {
        return _activityDuration; 
    }

    public int StartingMessage(string activityName, string activityDescription)
    {
        Console.Clear();
        Console.WriteLine(activityName);
        Console.WriteLine();
        Console.WriteLine(activityDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string activityDurationAsString = Console.ReadLine();
        int activityDuration = int.Parse(activityDurationAsString);
        _activityDuration = activityDuration;
        return _activityDuration;
    }

    public void EndingMessage(string activityName, int activityDuration)
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        //TODO: Pause animation
        Console.WriteLine();
        Console.WriteLine($"You completed {activityDuration} seconds of the {activityName}!"); 
        //TODO: Pause animation
        //TODO: Return to menu
    }
}