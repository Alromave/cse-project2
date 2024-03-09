public class Entry
{
    public string Date;
    public string Prompt;
    public string entry;

    public Entry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Date = DateTime.Now.ToString("MM/dd/YYYY");
        Prompt = promptGenerator.getRandomPromt();
    }

    public void setEntry (string new_entry)
    {
        entry = new_entry;
    }

    public void setDate(string new_date)
    {
        Date = new_date;
    }
}