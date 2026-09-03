using System.Collections.Generic;
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //to create a list of numbers
        List <int> numbers = new List<int>();

        int userInput =-1;
        // a loop to keep asking the user for numbers until they enter 0
        while (true)
        {
        
            Console.WriteLine("Enter a number (0 to quit): ");
            
                Console.WriteLine("Enter a number : ");  
            string input = Console.ReadLine();
            userInput = int.Parse(input);
            if (userInput == 0)
            {
                break;
            }
            //this is to add the user input to the list of numbers
            numbers.Add(userInput);
            }
            // compute the sum of the numbers in the list
            if (numbers.Count > 0)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum of the numbers is: {sum}");
        
            // average of the numbers in the list
            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average of the numbers is: {average}");
            //find the maximum number in the list
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    // if the current number is greater than the current maximum, we found a new max!
                    max = number;
                }
            }
                    Console.WriteLine($"The maximum number is: {max}");
                
                }
                else
                {
                    Console.WriteLine("No numbers were entered.");
                }
    
               
            }    
           }

