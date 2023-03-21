using System;

public class Comment
{
    private string _author = "";
    private string _contents = "";

    public Comment(string author, string text)
    {
        _author = author;
        _contents = text;
    }

    public void Display()
    {
        Console.WriteLine(_author);
        Console.WriteLine(_contents);
    }
}