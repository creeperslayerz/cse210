using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        Console.WriteLine("Welcome to Benski's Mindfuleness Program!");
        Console.WriteLine("What activity would you like to do today? ");
        string activityName = Console.ReadLine();
        Console.WriteLine("What is the description for the activity? ");
        string activityDescription = Console.ReadLine();
        Console.WriteLine("How long would you like to do it (in seconds)? ");
        string activityDurationAsString = Console.ReadLine();
        int activityDuration = int.Parse(activityDurationAsString);

        /*TODO: 
        Add menu options of 1,2,3 for the different activities. 
        Add if logic to get that actvity's description with a Getter. Then comment out Lines 11-12 where it asks for the description.*/ 

        BreathingActivity breathingActivity = new BreathingActivity(activityName, activityDescription, activityDuration);
        Console.WriteLine($"{activityName}\n{activityDescription}\n for {activityDuration} seconds");

        
    }
}