using System.Collections.Generic;
class ListConverter
{
    private List<string> _scriptureAsList = new List<string>();
    
    public List<string> DefaultScriptureToList() //Gets the _verseText out of Scripture class and splits it into a list called _scriptureAsList
    {
        Scripture defaultScripture = new Scripture();

        // The code below implemented https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
        string scripture = defaultScripture.GetVerse();
        string[] words = scripture.Split(" ");

        foreach(var word in words)
        {
            // Console.Write($"{word} ");
            _scriptureAsList.Add(word);
        }
        return _scriptureAsList;
    }

    public List<string> CustomScriptureToList() 
    {
        Scripture customScripture = new Scripture("customReference");

        // The code below implemented https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
        
        Console.WriteLine("Type out the text of the verse(s): *Pressing Enter begins the words being hidden. ");
        string customVerse = Console.ReadLine();

        string scripture = customVerse;
        string[] words = scripture.Split(" ");

        foreach(var word in words)
        {
            // Console.Write($"{word} ");
            _scriptureAsList.Add(word);
        }
        return _scriptureAsList;
    }

    public List<string> GetScriptureAsList() //Looks like I don't need this Get Method
    {
        return _scriptureAsList;
    }
}