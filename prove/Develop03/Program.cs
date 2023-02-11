using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        
        //TODO *Need to accomodate scriptures with multiple verses using Scripture(customReference) constructor
        
        Scripture scripture = new Scripture();
        scripture.DisplayReference(); //Displays scripture reference
        scripture.DisplayVerse(); //Displays scripture verse as a string

        Console.WriteLine("Press Enter to continue memorization exercise or type quit to be done. ");
        string theEnd = Console.ReadLine(); //If they type quit, the while loop won't happen.

        ListConverter listConverter = new ListConverter();
        List<string> verseAsList = listConverter.ConvertScriptureToList(); //Gets the _verseText out of Scripture class and splits it into a list called _scriptureAsList
        //I needed to create verseAsList outside of the while loop to save which words have already been hidden

        int runningTotal = 0;

        while(theEnd != "quit")
        {
            if(runningTotal == verseAsList.Count) //quit the program when all the words are hidden
            {
                theEnd = "quit";
            }
            else
            {    
                scripture.DisplayReference();

                MemorizeTool mTool = new MemorizeTool();
                verseAsList = mTool.WordHider(verseAsList); //Hides random word in verseAsList, displays it, then saves the new list as verseAsList to go through the loop again
                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue memorization exercise or type quit to be done. ");
                theEnd = Console.ReadLine();
            }
            runningTotal += 1;
        }        
    }
}
