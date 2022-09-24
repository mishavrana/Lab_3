namespace Lab_3;

public class Author
{
    private string author;

    public string GetAuthor
    {
        get { return author; }
        set { author = value; }
    }

    public void Show()
    {
        if (author != string.Empty)
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Author: {author}");
    }
}