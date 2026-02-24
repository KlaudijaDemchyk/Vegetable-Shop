public class VegetableShop
{
    private readonly List<Product> _products = new();

    public void AddProducts(List<Product> products)
    {
        if (products == null) return;

        foreach (var p in products)
        {
            if (p != null)
                _products.Add(p);
        }
    }

    public void PrintProductsInfo()
    {
        decimal total = 0;

        foreach (var p in _products)
        {
            Console.WriteLine(p.GetInfo());
            total += p.TotalPrice;
        }

        Console.WriteLine($"Total products price: {total.ToString("0.##", System.Globalization.CultureInfo.InvariantCulture)}");
    }
}
