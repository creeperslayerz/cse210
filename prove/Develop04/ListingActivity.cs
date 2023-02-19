public class ListingActivity : Activity
{
    private string _activityName = "Listing Activity";
    private string _listingActivityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    //TODO: create private List<string> _listPromptList

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
        //TODO: Pause animation
        Console.WriteLine("List as many responses you can to the following prompt:");
        //TODO: add random listPrompt from _listPromptList
        Console.WriteLine("You may begin in: "); //TODO: add countdown timer
        Console.Write("> "); 
        string answer = Console.ReadLine();
        //TODO: repeat WriteLine("> ") until activity duration is met
        int answerAmount = 1; //TODO: calculate running total for answerAmount from answer
        Console.WriteLine($"You completed {answerAmount} items!");


    }
}

