public class ReflectionActivity : Activity
{
    private string _activityName = "Reflection Activity";
    private string _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    private List<string> _memoryPromptList = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you accomplished something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you didn't want to do what needed to be done, but you did it anyway.",
        "Think of a time when you tried even though failure was the most likely outcome.",
        "Think of a time when you continued with the hope that you would get better."
    };

    private List<string> _reflectionPromptList = new List<string> 
    {
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "What motivated you to do this?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you remember this experience for future application?",
    };

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
        PauseAnimation();
        Console.WriteLine("Consider the following prompt:"); 
        Console.WriteLine();
        Console.WriteLine($" --- {RandomPromptGenerator(_memoryPromptList)} ---"); 
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue."); 
        string ready = Console.ReadLine();
        // Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountdownTimer(3);
        Console.WriteLine();
        
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetActivityDuration());
        while(currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write(RandomPromptGenerator(_reflectionPromptList));
            PauseAnimation(3);  //It will go through the animation cycles the same number of times as you put in the parenthesis
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

