using System.IO; 

public class Journal
{
    public List<NewEntry> _responseList = new List<NewEntry>();

    public Journal()
    {
    }

    public void DisplayJournal()
    {
        foreach(NewEntry entry in _responseList)
        {
            entry.Display();
        }
    }

    public void SaveJournal()
    {
        // string fileName = "journal.txt";

        // using(StreamWriter outputFile = new StreamWriter(filename))
        // {
        //     outputFile.WriteLine(_responseList);
        // }
    }

    public void LoadJournal()
    {
    // string filename = "journal.txt";
    // string[] lines = System.IO.File.ReadAllLines(filename);

    // foreach (string line in lines)
    // {
    //     string[] parts = line.Split("|");

    //     string date = parts[0];
    //     string prompt = parts[1];
    //     string response = parts[2];
    // }
    }

    public void JournalEntry()
    {
        PromptList _promptList = new PromptList();
        string prompt = _promptList.RandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        NewEntry _newEntry = new NewEntry();
        _newEntry._date = dateText;
        _newEntry._response = response;
        _newEntry._randomPrompt = prompt;

        _responseList.Add(_newEntry);
    }
}