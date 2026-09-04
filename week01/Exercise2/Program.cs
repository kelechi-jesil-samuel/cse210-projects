using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter  your grade? ");
        string grade = Console.ReadLine();
        float score = float.Parse(grade);
        String latter = "";
        
        if (score >=95)
        {
            latter = "A+";
        }
        else if (score >= 90)
        {
            latter = "A";
           
        }
        else if (score >= 85)
        {
            latter = "B+";
        }
        else if (score >= 80)
        {
            latter = "B";
        }
        else if (score >= 75)
        {
            latter ="C+";
        }
        else if (score >= 70)
        {
            latter = "C";
        }
        else if (score >= 65)
        {
            latter = "D+";
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
            latter = "F";
            Console.WriteLine("you failed. try again");
        }
        

    }
}