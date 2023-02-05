class Scripture
{
    private string _reference;
    private string _verseText;

    public Scripture()
    {
        _reference = "Philippians 4:13";
        _verseText = "I can do all things through Christ, which strentheneth me.";
    }
    public Scripture(string reference)
    {
        _reference = reference;
        Console.Write("What is the text of the verse(s)? ");
        _verseText = Console.ReadLine();
    }
    
    public string GetReference()
    {
        return _reference;
    }
    public string GetVerse()
    {
        return _verseText;
    }
    public void SetReference(string reference)
    {
        _reference = reference;
    }
    public void SetVerseText(string verseText)
    {
        _verseText = verseText;
    }

    public string DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(_reference);
        Console.WriteLine(_verseText);
        return _reference + _verseText;
        // return _verseText; //Looks like I can only return one string
    }
}