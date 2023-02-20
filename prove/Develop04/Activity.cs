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
        PauseAnimation();
        Console.WriteLine($"You completed {activityDuration} seconds of the {activityName}!"); 
        PauseAnimation();
    }

    public string RandomPromptGenerator(List<string> promptList)
    {
        Random random = new Random();
        int randomInt = random.Next(promptList.Count);
        string randomPrompt = promptList[randomInt];
        return randomPrompt;
    }

    public void PauseAnimation() //TODO: create parameter that tells it how many times to loop; set default at 1)
    {
        Console.Write(":-)");
        Thread.Sleep(1000);
        Console.Write("\b \b"); //Moves curser to the left, replaces with " " then moves curser back to the left again to be ready for new character
        Console.Write("p"); //Gives it a new mouth
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
        Console.Write("O"); 
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
        Console.Write("D"); 
        Thread.Sleep(1000);
        Console.WriteLine("\b\b\b   ");
    }

    public void CountdownTimer()
    {
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
        Console.Write("4"); 
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
        Console.Write("3"); 
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
        Console.Write("1"); 
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
}