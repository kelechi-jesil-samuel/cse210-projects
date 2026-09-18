class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found in file. Using default.");
            Reference reference = new Reference("Proverbs", 3, 5, 6);
            string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding";
            scriptures.Add(new Scripture(reference, text));
        }

        // Pick a random scripture
        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words hidden. Well done!");
                break;
            }
        }
    }

    static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        List<Scripture> list = new List<Scripture>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File not found: {filePath}");
            return list;
        }
        foreach (string line in File.ReadAllLines(filePath))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split('|');
            if (parts.Length!= 2) continue;

            string refString = parts[0].Trim();
            string text = parts[1].Trim();

            try
            {
                Reference reference = Reference.Parse(refString);
                Scripture scripture = new Scripture(reference, text);
                list.Add(scripture);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not parse line: {line} - {ex.Message}");
            }
        }
        return list;
    }
}