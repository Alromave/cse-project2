using System.Security.Cryptography.X509Certificates;
public class PromptGenerator
{
    Random random = new Random();
    public List<string>myPrompts = new List<string>()
    {
        "Who was the most interesting pereson I interacted with today?",
        "What was the best parte of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is the best memory today?",
        "Some verse from canonical books that struck me today?",
    };
    public string getRandomPromt()
    {
        int randomIndex = random.Next(0,myPrompts.Count);
        string prompt = myPrompts[randomIndex];
        return prompt;
    }
}