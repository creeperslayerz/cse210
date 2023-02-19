using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        Console.Clear();
        Console.WriteLine("Welcome to Benski's Mindfuleness Program!");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Breathing Activity");
        Console.WriteLine("  1. Reflecting Activity");
        Console.WriteLine("  1. Listing Activity");
        Console.WriteLine("  1. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string activity = Console.ReadLine();

        if(activity == "1")
        {
            BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity:");
            breathingActivity.BreathingExercise();
        }
        else if(activity == "2")
        {
            //Reflecting Activity
        }
        else if(activity == "3")
        {
            //Listing Activity
        }
        else //I opted to end the program if anythig other than 1,2,or3 gets input
        {
            Console.WriteLine("Enjoy the rest of your mindfulfilling day!");
        }




        

        
    }
}