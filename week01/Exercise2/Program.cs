using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter  your grade? ");
        string grade = Console.ReadLine();
        int score = int.Parse(grade);
        String latter = "";

        if (score >= 90)
        {
            latter = "A";
           
        }
        else if (score >= 80)
        {
            latter = "B";
        }
        else if (score >= 70)
        {
            latter ="C";
        }
        else if (score >= 60)
        {
            latter = "D";
        }
        else
        {
            latter = "F";
        }

        Console.WriteLine($"your Grade:{latter}");

        if (score >= 70)
        {
            Console.WriteLine("you passed congratulation!");
        }
        else
        {
            Console.WriteLine("you failed. try again");
        }

    }
}