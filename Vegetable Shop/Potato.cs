public sealed class Potato : Product
{
    public decimal Count { get; } 

    public Potato(decimal basePrice, decimal count) : base(basePrice)
    {
        Count = count < 0 ? 0 : count;
    }

    public override decimal TotalPrice => Price * Count;

    public override string GetInfo()
        => $"Product: {Name}, Price: {Format(Price)}, Count: {Format(Count)}, Total price: {Format(TotalPrice)}";
}
