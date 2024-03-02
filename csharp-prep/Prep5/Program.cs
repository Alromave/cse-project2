using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(UserNumber);
        DisplayResult(userName, SquaredNumber);
    }
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program?");
    }
    static string PromptUserName()  {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;

    }
    static int PromptUserNumber() {
        Console.WriteLine("What is your favorite number");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number) {
        int square = number * number;
        return square;


    }
    static void DisplayResult(string name, int square){
        Console.WriteLine($"{name}, the square of your numbre is {square}");

    }




    
};