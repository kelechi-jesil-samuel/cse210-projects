using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments;
    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        _comments = new List<Comment>();
    }

    public string GetTitle() { return _title; }
    public void SetTitle(string title) { _title = title; }

    public string GetAuthor() { return _author; }
    public void SetAuthor(string author) { _author = author; }

    public int GetVideoLength() { return _videoLength; }
    public void SetVideoLength(int length) { _videoLength = length; }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_videoLength} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment c in _comments)
        {
            c.Display();
        }
        Console.WriteLine();
    }
}