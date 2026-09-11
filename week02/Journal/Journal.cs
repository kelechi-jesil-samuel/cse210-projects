using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
{
    if (_entries.Count == 0)
    {
        Console.WriteLine("The journal is empty.");
        return;
    }

    foreach (Entry entry in _entries)
    {
        entry.Display();
    }
}
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // CSV header
            outputFile.WriteLine("Date,Prompt,Entry");

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToCsvString());
            }
        }

        Console.WriteLine($"Journal saved to {file}");
    }

    public void LoadFromFile(string file)
    {
        try
        {
            _entries.Clear();

            string[] lines = File.ReadAllLines(file);
            
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                int firstComma = line.IndexOf(',');
                int secondComma = line.IndexOf(',', firstComma + 1);

                if (firstComma != -1 && secondComma != -1)
                {
                    string date = line.Substring(0, firstComma);

                    string prompt = line.Substring(
                        firstComma + 1,
                        secondComma - firstComma - 1
                    );

                    string entryText = line.Substring(secondComma + 1);
                    prompt = prompt.Trim('"');
                    entryText = entryText.Trim('"');

                    Entry entry = new Entry(date, prompt, entryText);

                    _entries.Add(entry);
                }
            }

            Console.WriteLine($"Journal loaded from {file}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: Could not find file {file}");
        }
    }
}