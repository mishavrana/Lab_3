namespace Lab_3;

public class Book
{
    private Title title = new Title();
    private Author author = new Author();
    private Content content = new Content();
    

    public void AddTitle(string title)
    {
        this.title.GetTitle = title;
    }

    public void AddAuthor(string author)
    {
        this.author.GetAuthor = author;
    }

    public void AddContent(string content)
    {
        this.content.GetContent = content;
    }

    public void Show()
    {
        title.Show();
        author.Show();
        content.Show();
    }
}