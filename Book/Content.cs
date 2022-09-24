namespace Lab_3;

public class Content
{
    private string content;

    public string GetContent
    {
        get { return content; }
        set { content = value; }
    }
    
    public void Show()
    {
        if (content != string.Empty)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Content: {content}");
        }
    }
}