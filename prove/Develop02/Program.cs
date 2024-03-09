using System;
class Program
{
    
    static void Main(string[] args)
    {
        Journal myJournal = new Journal("Alvaro");
        Console.WriteLine("Welcome to your Journal Program");
        bool programRunning = true;

        while (programRunning == true)
        {
            Console.WriteLine("Please select your option");
            Console.WriteLine ("1 = Write");
            Console.WriteLine ("2 = Display");
            Console.WriteLine ("3 = Save");
            Console.WriteLine ("4. = Load");
            Console.WriteLine ("5. = Quit");
            Console.WriteLine ("What is your option");
            string userChoice = Console.ReadLine();
            if( userChoice == "1")
            {
                Entry NewEntry = new Entry();
                Console.WriteLine(NewEntry.Prompt);
                string Answer = Console.ReadLine();
                NewEntry.setEntry(Answer);
                myJournal.AddEntry(NewEntry);
            }
            else if (userChoice == "2")
            {
                for (int i = 0; i < myJournal.entries.Count; i ++)
                {
                    Console.WriteLine("------");
                    Console.WriteLine(myJournal.entries[i].Date);
                    Console.WriteLine(myJournal.entries[i].entry);
                }
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("What is the file name");
                string myfileName = Console.ReadLine();
                using (StreamWriter writer = new StreamWriter(myfileName))
                {
                    writer.WriteLine("Date, Entry");
                    foreach (var entry in myJournal.entries)
                    {
                        writer.WriteLine($"{entry.Date} | {entry.entry}");
                    }
                };
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("What is your file name");
                string LoadFileName = Console.ReadLine();
                using (StreamReader reader = new StreamReader (LoadFileName))
                {
                    string headerLine = reader.ReadLine();
                
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();33
                        string [] values = line.Split("|");
                        Entry newEntry = new Entry();
                        newEntry.setDate(values[0]);
                        newEntry.setEntry(values[1]);
                        myJournal.AddEntry(newEntry);

                    }

            }
        }
        else
        {
            programRunning = false;
        }
        }
    } 
    
}