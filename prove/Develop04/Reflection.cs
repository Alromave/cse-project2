// Reflection Activity
class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> reflectionQuestions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration) : base(duration) { }

    protected override void PerformActivity()
    {
        Random random = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string randomPrompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(randomPrompt);
            Thread.Sleep(3000); // Pause for 3 seconds

            foreach (string question in reflectionQuestions)
            {
                Console.WriteLine(question);
                ShowSpinner(2); // Pause for 2 seconds
            }
        }
    }

    protected override string GetDescription()
    {
        return "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    private void ShowSpinner(int seconds)
    {
        string[] spinner = { "-", "\\", "|", "/" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            foreach (string spin in spinner)
            {
                Console.Write("\r{0}", spin);
                Thread.Sleep(250);
            }
        }
        Console.WriteLine();
    }
}