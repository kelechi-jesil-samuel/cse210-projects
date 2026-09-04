using System;

namespace game {

class Program
{
    static void Main(string[] args)
    {
        // note console.writeline is print statement
        Console.WriteLine("wHat is your first name? ");
        string first_name = Console.ReadLine();

        Console.WriteLine("What is your last name ? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"your name is {first_name}, {first_name} {last_name}");

       



     
    }
}
}