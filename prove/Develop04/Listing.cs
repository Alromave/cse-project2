// Listing Activity
class ListingActivity : Activity
{
    private List<string> prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string randomPrompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(randomPrompt);
        Console.WriteLine("You have " + duration + " seconds to think and list as many items as you can.");
        Thread.Sleep(5000); 

        Console.WriteLine("Please start listing...");

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int itemsCount = 0;
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                itemsCount++;
        }

        Console.WriteLine("You listed " + itemsCount + " items.");
    }

    protected override string GetDescription()
    {
        return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
}