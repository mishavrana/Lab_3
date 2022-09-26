using System.Reflection.Metadata;

namespace Lab3 ;

public class Invoice
{
    private readonly int account;
    private readonly string customer;
    private readonly string provider;

    private string article;
    private int quantity;

    private double valueAddedTax;

    public Invoice(int account, string customer, string provider, string article, int quantity, double vat)
    {
        this.account = account;
        this.customer = customer;
        this.provider = provider;
        this.article = article;
        this.quantity = quantity;
        this.valueAddedTax = vat / 100; // to convert from percentage form 
    }

    public double Sum()
    {
        double sum = (double) account * quantity;
        return sum;
    }

    public double SumWithValueAddedTax()
    {
        double currentVat = (double) account * quantity * valueAddedTax;
        double sum = currentVat + (double) account * quantity;
        return sum;
    }
}