public class BreathingActivity : Activity
{
    private string _breathingActivityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity(string activityName, string breathingActivityDescription, int activityDuration) : base(activityName, activityDuration)
    {
        _breathingActivityDescription = breathingActivityDescription;
    }
}

