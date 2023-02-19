public class ReflectionActivity : Activity
{
    private string _activityName = "Reflection Activity";
    private string _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    //TODO: create private List<string> _memoryPromptList

    //TODO: create private List<string> _reflectionPromptList

    public ReflectionActivity(){}

    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public void ReflectionExercise()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        //TODO: Pause animation
        Console.WriteLine("Consider the following prompt:"); 
        Console.WriteLine();
        //TODO: add random memoryPrompt from _memoryPromptList
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue."); 
        string ready = Console.ReadLine();
        Console.WriteLine("You may begin in: "); //TODO: add countdown timer
        //TODO: Console.Clear() when countdown timer finishes
        //TODO: add random reflectionPrompt from _reflectionPromptList
        //TODO: add pause animation
        //TODO: continue adding random reflection prompts and pause animations until activity duration is met





    }
}

