public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // new Parses "John 3:16" or "Proverbs 3:5-6" or "2 Nephi 2:25"
    public static Reference Parse(string referenceString)
    {
        referenceString = referenceString.Trim();
        int lastSpace = referenceString.LastIndexOf(' ');
        string book = referenceString.Substring(0, lastSpace);
        string chapterVerse = referenceString.Substring(lastSpace + 1);

        string[] chapterSplit = chapterVerse.Split(':');
        int chapter = int.Parse(chapterSplit[0]);
        string versePart = chapterSplit[1];
        if (versePart.Contains("-"))
        {
            string[] verseSplit = versePart.Split('-');
            int start = int.Parse(verseSplit[0]);
            int end = int.Parse(verseSplit[1]);
            return new Reference(book, chapter, start, end);
        }
        else
        {
            int verse = int.Parse(versePart);
            return new Reference(book, chapter, verse);
        }
    }

    public string GetDisplayText()
    {
        if (_verse == _endVerse)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}