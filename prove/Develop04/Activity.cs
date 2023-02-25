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
        Console.WriteLine();
        Console.WriteLine($"You completed {activityDuration} seconds of the {activityName}!"); 
        PauseAnimation();
        Console.WriteLine();
    }

    public string RandomPromptGenerator(List<string> promptList) //TODO: Make it so the prompts don't repeat until they've all been done
    {
        
        List<string> copyOfList = new List<string>{}; //I need to somewhere outside of this method, but can't figure out where...
        Random random = new Random();
        int randomInt = random.Next(promptList.Count);
        string randomPrompt = promptList[randomInt];
        copyOfList.Add(randomPrompt);
        promptList.Remove(randomPrompt);
        if(promptList.Count == 0)
        {
            promptList = copyOfList;
        }
        return randomPrompt;

        // List<string> copyOfList = new List<string>(promptList);
        // if(copyOfList.Count == 0)
        // {
        //     copyOfList = new List<string>(promptList);
        // }
        // Random random = new Random();
        // int randomInt = random.Next(copyOfList.Count);
        // string randomPrompt = copyOfList[randomInt];
        // copyOfList.Remove(randomPrompt);
        // return randomPrompt;
    }

    public void PauseAnimation(int animationCycle = 1) 
    // Created parameter that tells it how many times to loop; set default at 1)
    {
        int loopCount = 1;
        do
        {
            loopCount += 1;
            Console.Write(":-)");
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
            //Moves curser to the left, replaces with " " then moves curser back to the left again to be ready for new character
            Console.Write("p"); //Gives it a new mouth
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
            Console.Write("O"); 
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
            Console.Write("D"); 
            Thread.Sleep(1000);
            Console.Write("\b\b\b   \b\b\b");
        }while(loopCount <= animationCycle);
    }

    public void CountdownTimer() //TODO: modify this method to set length of timer as the parameter
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