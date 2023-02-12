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
        int randomInt1 = wordSelector.Next(verse.Count); //randomInt is assigned a random number from length of verse list
        int randomInt2 = wordSelector.Next(verse.Count);

        while(verse[randomInt1] == _hiddenWord) 
        {
            randomInt1 = wordSelector.Next(verse.Count); //randomInt is assigned numbers until it doesn't equal hidden word 
        }

        verse.RemoveAt(randomInt1); //removes and replaces word in randomInt location
        verse.Insert(randomInt1, _hiddenWord);

        while(verse[randomInt2] == _hiddenWord) 
        {
            randomInt2 = wordSelector.Next(verse.Count); //randomInt is assigned numbers until it doesn't equal hidden word 
        }
        
        verse.RemoveAt(randomInt2); 
        verse.Insert(randomInt2, _hiddenWord);
        // implemented code found at https://stackoverflow.com/questions/8063058/how-to-replace-some-particular-string-in-a-list-of-type-string-using-linq

        foreach(string word in verse)
        {
            Console.Write($"{word} ");
        }            

        return verse;        
    }
}