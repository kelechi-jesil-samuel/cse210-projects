using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string username = PromptUserName();
        int userNumber = PromptUserNumber();

        int SquaredNumber = SquareNumber(userNumber);

        DisplayResults(username, SquaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        return number;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResults(string username, int squaredNumber)
    {
        Console.WriteLine($" {username}! The square of your favorite number is {squaredNumber}.");
    }
}