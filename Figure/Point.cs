namespace Lab3;

class Point
{
    private int x = 0;
    private int y = 0;
    private string name;
    
    // private string someField; // maybe it should be the name of the point? 
  
    public int X => x;
    public int Y => y;
    //public string Name => name;

    public Point(int x, int y, string name = "some point")
    {
        this.x = x;
        this.y = y;
        //this.name = name;
    }
}

