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
        Console.WriteLine("What file name would you like to save it to? ");
        string fileName = Console.ReadLine();

        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(NewEntry entry in _responseList)
            {
                outputFile.WriteLine($"{entry._date}|{entry._randomPrompt}|{entry._response}");
            }            
        }
    }

    public void LoadJournal()
    {
        Console.WriteLine("What file name would you like to load from? ");
        string fileName = Console.ReadLine();
    
        _responseList.Clear();
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        foreach(string line in lines)
        {
            string[] parts = line.Split("|");

            NewEntry entry = new NewEntry();
            
            entry._date = parts[0];
            entry._randomPrompt = parts[1];
            entry._response = parts[2];

            _responseList.Add(entry);
        }
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