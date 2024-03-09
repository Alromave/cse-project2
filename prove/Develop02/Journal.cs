public class Journal
{
    public string Title;
    public List<Entry> entries = new List<Entry>();
    public Journal(string userName)
    {
        Title = userName;

    }
    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }
}