// Actividad de Respiración
class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    protected override void PerformActivity()
    {
        Console.WriteLine("Let's start breathing...");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000); // Pause for 2 seconds
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000); // Pause for 2 seconds
        }
    }

    protected override string GetDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
}
