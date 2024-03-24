// Pondering Activity
class PonderingActivity : Activity
{
    private List<string> prompts = new List<string> {
        "'The only way to do great work is to love what you do' - Steve Jobs",
        "'In the end, it's not the years in your life that count. It's the life in your years.' - Abraham Lincoln",
        "'You miss 100% of the shots you don't take.' - Wayne Gretzky",
        "'The greatest glory in living lies not in never falling, but in rising every time we fall.' - Nelson Mandela",
        "'Believe you can and you're halfway there.' - Theodore Roosevelt",
        "'The only limit to our realization of tomorrow will be our doubts of today.' - Franklin D. Roosevelt",
        "'Success is not final, failure is not fatal: It is the courage to continue that counts.' - Winston Churchill",
        "'Your time is limited, don't waste it living someone else's life.' - Steve Jobs",
        "'Life is what happens when you're busy making other plans.' - John Lennon",
        "'The only person you should try to be better than is the person you were yesterday.' - Unknown",
        "'In three words I can sum up everything I've learned about life: it goes on.' - Robert Frost",
        "'Happiness is not something ready-made. It comes from your own actions.' - Dalai Lama",
        "'You must be the change you wish to see in the world.' - Mahatma Gandhi",
        "'The future belongs to those who believe in the beauty of their dreams.' - Eleanor Roosevelt",
        "'The only way to do great work is to love what you do.' - Steve Jobs",
        "'It does not matter how slowly you go as long as you do not stop.' - Confucius",
        "'The best time to plant a tree was 20 years ago. The second best time is now.' - Chinese Proverb",
        "'We may encounter many defeats but we must not be defeated.' - Maya Angelou",
        "'Don't watch the clock; do what it does. Keep going.' - Sam Levenson",
        "'The only thing we have to fear is fear itself.' - Franklin D. Roosevelt",
    };
    public PonderingActivity(int duration) : base(duration) { }

    protected override void PerformActivity()
    {
        Random random = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string randomPrompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(randomPrompt);
            Thread.Sleep(3000); // Pause for 3 seconds

        }
    }
    protected override string GetDescription()
    {
return "This activity will help you to meditate on inspirational words";
    }
    
            
    
}