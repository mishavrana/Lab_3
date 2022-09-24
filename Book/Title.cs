namespace Lab_3;

public class Title
{
    private string title;

    public string GetTitle
    {
        get { return title; }
        set { title = value; }
    }
    
    public void Show()
    {
        if (title != string.Empty)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Title: {title}");
        }
        
    }
}