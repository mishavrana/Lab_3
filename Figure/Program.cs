namespace Lab3;
class Program
{
    private static Point pointOne = new Point(0, 0);
    private static Point pointTwo = new Point(5, 5);
    private static Point pointThree = new Point(10, 0);
    
    private static Figure triangular = new Figure
    (
        pointOne, 
        pointTwo,
        pointThree
    );
    static void Main(string[] args) 
    { 
      triangular.Show();
    }
}
