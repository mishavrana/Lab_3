namespace Lab_3;

public class Rectangle
{
    private double side1;
    private double side2;

    public double Side1
    {
        get { return side1; }
        set { side1 = value; }
    }

    public double Area
    {
        get { return AreaCalculator(); }
    }

    public double Perimeter
    {
        get { return PerimeterCalculator(); }
    }

     private double AreaCalculator()
    {
        return side1 * side2;
    }

    private double PerimeterCalculator()
    {
        return side1 * 2 + side2 * 2;
    }

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
}