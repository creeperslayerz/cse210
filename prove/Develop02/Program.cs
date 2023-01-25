using System;

class Program //Journal Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();        
        string menuChoice = "";

        while(menuChoice != "5")
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            menuChoice = Console.ReadLine();

            if(menuChoice == "1")
            {
                journal.JournalEntry();
            }
            else if(menuChoice == "2")
            {
                journal.DisplayJournal();
            }
            else if(menuChoice == "3")
            {
                journal.LoadJournal();
            }
            else if(menuChoice == "4")
            {
                journal.SaveJournal();
            }
            
        }    
    }

    static void Menu()
    {

    }
}