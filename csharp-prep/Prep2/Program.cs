using System;

class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("What is your grade?");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";
        if(number >= 90){
            letter = "A";
            //Console.WriteLine ("your grade letter is A");
        }
        else if(number >= 80){
            letter = "B";
            //Console.WriteLine ("your grade letter is B");
        }
        else if (number >= 70) {
            letter = "C";
            //Console.WriteLine ("your grade letter is C");
        }
        else if (number >= 60) {
            letter = "D";
            
            //Console.WriteLine ("your grade letter is D");
        }
        else {
            letter = "F";
            //Console.WriteLine ("your grade letter is F");
        }
        Console.WriteLine($"Your leeter grade is {letter}");
        if (number >= 70) {
            Console.WriteLine($"Contratulations you passed, your score is {number} ");
        }
        else {
            Console.WriteLine($" I am sorry your are not passed,  try again, your score is {number}");
        };
    

    }
}