public class Activity
{
    private int _activityDuration;

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

    //TODO: Create string RandomPromptGenerator(List<string> promptList) method

    //TODO: Create void PauseAnimation() method

    //TODO: Create void CountdownTimer() method
}