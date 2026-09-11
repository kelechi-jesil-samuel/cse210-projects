using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int choice = 0;

        while (choice!= 5)
        {
            Console.WriteLine("\nWelcome to My Journal");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit");

            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a number 1-5.");
                continue;
            }

            if (choice == 1)
            {
                string keepGoing = "yes";

                while (keepGoing.ToLower() == "yes")
                {
                    string prompt = promptGenerator.GetRandomPrompt();
                    
                    Console.Write($"\n{prompt}: ");
                    string response = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();
                    Entry newEntry = new Entry(date, prompt, response);
                    theJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully");

                    Console.Write("\nWrite another entry? yes/no: ");
                    keepGoing = Console.ReadLine();
                }
            }
           else if (choice == 2)
{
    theJournal.DisplayAll();
    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
}
else if (choice == 3)
{
    Console.Write("Type in filename: ");
    string file = Console.ReadLine();
    if (!file.EndsWith(".csv"))
    {
        file += ".csv";
    }
    //This prints "Journal saved to"
    theJournal.SaveToFile(file);
    
    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
}
            
            else if (choice == 4)
            {
                Console.Write("Input filename: ");
                string file = Console.ReadLine();
                if (!file.EndsWith(".csv"))
                {
                    file += ".csv";
                }
                theJournal.LoadFromFile(file);
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Wrong command. Please select from 1-5.");
            }
        }
    }
}