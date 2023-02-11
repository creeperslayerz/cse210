class Scripture
{
    private string _reference;
    private string _verseText;

    public Scripture()
    {
        _reference = "Philippians 4:13";
        _verseText = "I can do all things through Christ, which strengtheneth me.";
    }
    public Scripture(string customReference)
    {
        _reference = customReference;
        Console.WriteLine("Type out the text of the verse(s)? ");
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
    
    public string DisplayReference()
    {
        Console.Clear();
        Console.WriteLine(_reference);
        return _reference;
    }
    public string DisplayVerse()
    {
        Console.WriteLine(_verseText);
        Console.WriteLine();
        return _verseText;
    }
}