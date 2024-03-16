using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        

        Scripture scripture = new Scripture("John 1: 23", "He said I am the voice of one crying in the wilderness, Make straight the way of the Lord, as said the prophet Esaias.");
        while (true){
            Console.WriteLine(scripture.Reference + " " + scripture.DisplayVerse());
            System.Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string userInput = Console.ReadLine();

            if(userInput == "quit" || scripture.isAllVerseHidden() == true){
                break;
            }
            scripture.EraseRandomWord();
            Console.Clear();
        }
        

    }
}