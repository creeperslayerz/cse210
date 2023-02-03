public class NewEntry
{
    public string _randomPrompt;
    public string _response;
    public string _date;

    // public NewEntry()
    // {
    // }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_randomPrompt}");
        Console.WriteLine($"{_response}");
    }
}