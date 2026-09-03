using System;

namespace game {

class Program
{
    static void Main(string[] args)
    {
        // note console.writeline is print statement
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("THIS IS C#");

        Console.WriteLine("wHat is your first name? ");
        string first_name = Console.ReadLine();
        Console.WriteLine($"my first  name is {first_name}");

        Console.WriteLine("What is your last name ? ");
        string last_name = Console.ReadLine();
        Console.WriteLine($" my last name is {last_name}");

        Console.WriteLine($"your name is {first_name} {last_name}");

       



     
    }
}
}