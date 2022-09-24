namespace Lab_3;

class Program
{
    private static Book book = new Book();
    static void Main(string[] args)
    {
        book.AddAuthor("Rudyard Kipling");
        book.AddTitle("Jungle Book");
        book.Show();
    }
}