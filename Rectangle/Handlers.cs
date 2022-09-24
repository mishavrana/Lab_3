namespace Lab_3;

public class Handlers
{
    public static double TryToParseToDouble(string data)
    {
        try
        {
            double value = double.Parse(data);
            if (value > 0)
            {
                return value;
            }
            throw new Exception("Not appropriate number");

        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return 0;
    }
}