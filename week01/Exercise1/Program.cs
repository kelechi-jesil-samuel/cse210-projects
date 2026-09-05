using System;

namespace game {

class Program
{
    static void Main(string[] args)
    {
        // note console.writeline is print statement
        Console.WriteLine("wHat is your first name? ");
        string firstname = Console.ReadLine();

        Console.WriteLine("What is your last name ? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"your name is {firstname}, {firstname} {lastname}");

       



     
    }
}
}