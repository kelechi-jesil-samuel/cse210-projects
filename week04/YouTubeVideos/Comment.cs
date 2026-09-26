public class Comment
{
    private string _nameOfCommenter;
    private string _commentContent;

    public Comment(string nameOfCommenter, string commentContent)
    {
        _nameOfCommenter = nameOfCommenter;
        _commentContent = commentContent;
    }
    public string GetNameOfCommenter() { return _nameOfCommenter; }
    public void SetNameOfCommenter(string name) { _nameOfCommenter = name; }
    public string GetCommentContent() { return _commentContent; }
    public void SetCommentContent(string content) { _commentContent = content; }

    public void Display()
    {
        Console.WriteLine($"  {_nameOfCommenter}: {_commentContent}");
    }
}