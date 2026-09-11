public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }

  public string ToCsvString()
    {
        string safePrompt = $"\"{_promptText.Replace("\"", "\"\"")}\"";
        string safeEntry = $"\"{_entryText.Replace("\"", "\"\"")}\"";

        return $"{_date},{safePrompt},{safeEntry}";
    }
}