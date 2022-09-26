using System.Reflection.Metadata.Ecma335;

namespace Lab3; 

class Figure // this figure can fave maximum 5 sides
{
    private static Point pointOne; 
    private static Point pointTwo; 
    private static Point pointThree; 
    private static Point pointFour;
    private static Point pointFive;

    private FigureType type;

    // Constructor for triangular
    public Figure (Point pointOne, Point pointTwo, Point pointThree)
    { 
        Figure.pointOne = pointOne;
        Figure.pointTwo = pointTwo;
        Figure.pointThree = pointThree;
        
        type = FigureType.Triangular;
    }
    
    // Constructor for rectangular
    public Figure (Point pointOne, Point pointTwo, Point pointThree, Point pointFour)
    { 
        Figure.pointOne = pointOne;
        Figure.pointTwo = pointTwo;
        Figure.pointThree = pointThree;
        Figure.pointFour = pointFour;

        type = FigureType.Rectangular;
    }
    
    // Constructor for pentagon
    public Figure (Point pointOne, Point pointTwo, Point pointThree, Point pointFour, Point pointFive)
    { 
        Figure.pointOne = pointOne;
        Figure.pointTwo = pointTwo;
        Figure.pointThree = pointThree;
        Figure.pointFour = pointFour;
        Figure.pointFive = pointFive;

        type = FigureType.Pentagon;
    }

    double LengthOfTheSide(Point pointA, Point pointB)
    {
        return Math.Sqrt
        (
            Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA!.Y, 2)

        );
    }

    void PerimeterCalculator()
    {
        Point[] points = { pointOne, pointTwo, pointThree, pointFour, pointFive };
        double perimeter = 0.0;
        for (int i = 0; i < points.Length - 2; i++)
        {
            if (points?[i] != null && points?[i+1] != null )
            {
                perimeter += LengthOfTheSide(points[i], points[i+1]); 
            }
            else if (points?[0] != null && points?[i] != null)
            {
                perimeter += LengthOfTheSide(points[i]!, points[0]!);
            }
        }
        Console.WriteLine($"Perimeter = {Math.Round(perimeter, 2)}");
    }

    public void Show()
    {
        Console.WriteLine($"Type of the figure: {type.ToString()}");
        PerimeterCalculator();
    }
    
    
    private enum FigureType
    {
        Triangular, 
        Rectangular, 
        Pentagon,
    }
}
