using System;

class Program
{
    static void Main(string[] args)
    {
        Goal blankGoal = new Goal();
        string choice = "-1";

        while(choice != "6")
        {
            Console.WriteLine();
            Console.WriteLine($"You have {blankGoal.GetUserScore()} points."); 
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.WriteLine();
            if(choice == "1")
            {
                blankGoal.CreateNewGoal();
            }
        }
    }   
}