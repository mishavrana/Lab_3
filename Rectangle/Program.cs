using static System.Console;


namespace Lab_3 
{
    class Program
    {
        static void Main(string[] args)
        {
            CountPerimeterAndAreaOfRectangle();
        }

        static void CountPerimeterAndAreaOfRectangle()
        {
            double side1 = 0;
            double side2 = 0;

            while (side1 == 0)
            {
                WriteLine("Enter the length of the first side: ");
                side1 = Handlers.TryToParseToDouble(Console.ReadLine()!);
            }
            
            while (side2 == 0)
            {
                WriteLine("Enter the length of the second side: ");
                side2 = Handlers.TryToParseToDouble(Console.ReadLine()!);
            }

            Rectangle rectangle = new Rectangle(side1, side2);
            
            Console.WriteLine($"Perimeter = {rectangle.Perimeter}");
            Console.WriteLine($"Area = {rectangle.Area}");
        }
    }
}