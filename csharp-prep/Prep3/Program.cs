using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is your magic number?");
        //string answer  = Console.ReadLine();
        //int magicNumber = int.Parse(answer);
        Random randomgGenerator = new Random();
        int magicNumber = randomgGenerator.Next(1,101);
        int guessNumber = -1;
        while (guessNumber != magicNumber) {
            Console.WriteLine("What is your guess number");
            string answer1 = Console.ReadLine();
            guessNumber = int.Parse(answer1);
            

        
            if(magicNumber > guessNumber){
                Console.WriteLine("Higher");

                

        
            }
            else if(magicNumber < guessNumber) {
             Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("Guessed it!");

                }    
           }
        
    }
}