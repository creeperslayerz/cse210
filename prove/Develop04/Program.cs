using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Console.WriteLine("Welcome to Benski's Mindfulness Program!");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Breathing Activity");
        Console.WriteLine("  2. Reflecting Activity");
        Console.WriteLine("  3. Listing Activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        string activity = Console.ReadLine();

        //TODO: create while loop to continue while(activity != "4")
        if(activity == "1")
        {
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.StartingMessage(breathingActivity.GetActivityName(), breathingActivity.GetActivityDescription());
            breathingActivity.BreathingExercise();
            breathingActivity.EndingMessage(breathingActivity.GetActivityName(), breathingActivity.GetActivityDuration());
        }
        else if(activity == "2")
        {
            ReflectionActivity reflectionActivity = new ReflectionActivity();
            reflectionActivity.StartingMessage(reflectionActivity.GetActivityName(), reflectionActivity.GetActivityDescription());
            reflectionActivity.ReflectionExercise();
            reflectionActivity.EndingMessage(reflectionActivity.GetActivityName(), reflectionActivity.GetActivityDuration());
        }
        else if(activity == "3")
        {
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.StartingMessage(listingActivity.GetActivityName(), listingActivity.GetActivityDescription());
            listingActivity.ListingExercise();
            listingActivity.EndingMessage(listingActivity.GetActivityName(), listingActivity.GetActivityDuration());
        }
        else 
        {
            Console.WriteLine("Please enter a valid option from the menu.");
        }




        

        
    }
}