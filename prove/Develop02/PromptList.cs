using System.Collections.Generic;

public class PromptList
{
    List<string> _promptList = new List<string>
    {
    "What part of today did you most enjoy? ",
    "What is something that made you smile today? ",
    "What was your biggest achievement today? ",
    "What part of today did you most enjoy? ",
    "Did you make time for yourself today? If so, how? If not, how can you start to do this? ",
    "Talk about someone in your life today you are grateful for. ",
    "What was the hardest thing today, and how did you handle it? ",
    "Did you make a mistake today? What happened? ",
    "What is something that made you laugh today? ",
    "Did you procrastinate anything today? How can you tackle it? ",
    };

    public string RandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomInt = randomGenerator.Next(_promptList.Count);
        string randomPrompt = _promptList[randomInt];
        return randomPrompt;
    }
}
