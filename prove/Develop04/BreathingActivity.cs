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
        PauseAnimation();
        Console.WriteLine();

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetActivityDuration());
        while(currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write("Breath In..."); 
            CountdownTimer();
            Console.WriteLine();
            Console.Write("Breath Out..."); 
            CountdownTimer();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

