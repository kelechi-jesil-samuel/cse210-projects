using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        //while loop
        string response;
        do
        {
            Console.WriteLine("Enter your grade: ");
            response = Console.ReadLine();
        } while (response == "yes");

        // for loop
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"your grade is: {i}");
            Console.WriteLine(i);
        }
        // for each loop
        string[] colors = { "red", "green", "blue" };
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        */
        Random randomGenerator = new Random();
        Console.WriteLine("WELCOME TO GUESS GAME");
        int magic_number = randomGenerator.Next(1, 100);
        int guess_number;
            
                while(true)
                {
                    Console.WriteLine("what is your guess number: ");
                    string guess = Console.ReadLine();
                    guess_number = int.Parse(guess);
                    if (guess_number > magic_number )
                    {
                        Console.WriteLine("lower");
                    }
                    else if (guess_number < magic_number)
                    {
                        Console.WriteLine("higher");
                    }
                    else
                    {
                        Console.WriteLine("you guessed the magic number");
                    break;
                    }
                }
               

    }
}