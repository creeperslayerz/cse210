class ListConverter
{
    private List<string> _scriptureAsList = new List<string>();
    
    public void ConvertScriptureToList() 
    {
        Scripture defaultScripture = new Scripture();

        // The code below implemented https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
        string scripture = defaultScripture.GetVerse();
        string[] words = scripture.Split(" ");

        foreach(var word in words)
        {
            Console.Write($"{word} ");
            _scriptureAsList.Add(word);
        }
        // Console.WriteLine(_scriptureAsList);
    }

    public List<string> GetScriptureAsList()
    {
        return _scriptureAsList;
    }
}