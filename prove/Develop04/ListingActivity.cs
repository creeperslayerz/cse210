public class ListingActivity : Activity
{
    private string _activityName = "Listing Activity";
    private string _listingActivityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> _listPromptList = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strenghts of yours?",
        "Who are people that have helped you this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    private List<string> _listResponseList = new List<string> {}; //This is just in case the user wants to save/refer back to their list (future build option)

    public ListingActivity(){}
    
    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetActivityDescription()
    {
        return _listingActivityDescription;
    }

    public void ListingExercise()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseAnimation();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {RandomPromptGenerator(_listPromptList)} ---"); 
        Console.Write("You may begin in: "); 
        CountdownTimer(3);
        Console.WriteLine();
        
        int answerAmount = 0;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetActivityDuration());
        while(currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write("> "); 
            string answer = Console.ReadLine(); //Possibly save _listResponseList to another file as future build option
            _listResponseList.Add(answer);
            answerAmount += 1; 
        }
        Console.WriteLine($"You listed {answerAmount} items!");
    }
}

