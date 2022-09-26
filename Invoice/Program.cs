namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        Invoice invoice = new Invoice
        (
            20,
            "Den",
            "Hewlett-Packard",
            "0838472847",
            20,
            18
        );

        Console.WriteLine($"Sum without VAT = {invoice.Sum() } UAH");
        Console.WriteLine($"Sum with VAT = {invoice.SumWithValueAddedTax() } UAH");
    }
}
