// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class test { 
public decimal CalculateDiscount(decimal amount)
{
    if (amount > 100m)
        return amount * 0.15m;

    if (amount > 500m && amount < 1000m)
        return amount * 0.10m;

    return 0m;
}
}