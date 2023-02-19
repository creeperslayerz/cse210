public class BreathingActivity : Activity
{
    private string _breathingActivityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity(string activityName) : base(activityName)
    {
        // _breathingActivityDescription = breathingActivityDescription;
    }

    public void BreathingExercise()
    {
        Console.Clear();
        Console.WriteLine("Breathing Activity:");
        Console.WriteLine();
        Console.WriteLine(_breathingActivityDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string activityDurationAsString = Console.ReadLine();
        int activityDuration = int.Parse(activityDurationAsString);



    }
}

