public class BreathingActivity : Activity
{
    private string _activityName = "Breathing Activity";
    private string _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity(){}

    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public void BreathingExercise()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        //TODO: Pause animation
        Console.WriteLine("Breath In..."); //TODO: add countdown timer
        Console.WriteLine("Breath Out..."); //TODO: add countdown timer
        //TODO: add loop to continue cycle until activityDuration is met
        


    }
}
