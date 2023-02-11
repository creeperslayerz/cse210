class MemorizeTool
{
    private string _hiddenWord;

    public MemorizeTool()
    {
        _hiddenWord = "___";
    }

    public List<string> WordHider(List<string> verse)
    {
        Random wordSelector = new Random();
        int randomInt = wordSelector.Next(verse.Count); //randomInt is assigned a random number from length of verse list
        
        while(verse[randomInt] == _hiddenWord) 
        {
            randomInt = wordSelector.Next(verse.Count); //randomInt is assigned numbers until it doesn't equal hidden word 
        }

        verse.RemoveAt(randomInt); //removes and replaces word in randomInt location
        verse.Insert(randomInt, _hiddenWord);
        // implemented code found at https://stackoverflow.com/questions/8063058/how-to-replace-some-particular-string-in-a-list-of-type-string-using-linq

        foreach(string word in verse)
        {
            Console.Write($"{word} ");
        }            

        return verse;        
    }
}