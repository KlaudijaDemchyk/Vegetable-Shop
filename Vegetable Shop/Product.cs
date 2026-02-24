using System.Globalization;

public abstract class Product
{
    private readonly decimal _basePrice; 

    protected Product(decimal basePrice)
    {
        _basePrice = basePrice < 0 ? 0 : basePrice;
    }

    public string Name => GetType().Name;

    public virtual decimal Price => _basePrice;

    public virtual decimal TotalPrice => Price;

    public virtual string GetInfo()
        => $"Product: {Name}, Price: {Format(Price)}";

    protected static string Format(decimal value)
        => value.ToString("0.##", CultureInfo.InvariantCulture);
}
