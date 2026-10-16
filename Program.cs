namespace G_NET_84_LINQ;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Question 1: Seafood products");

        var seafoodProducts = ProductList.All
            .Where(product => product.Category == "Seafood");

        foreach (var product in seafoodProducts)
        {
            Console.WriteLine($"{product.ProductName} - {product.UnitPrice:C}");
        }

        Console.WriteLine("\nQuestion 2: Product names");

        var productNames = ProductList.All
            .Select(product => product.ProductName);

        foreach (var productName in productNames)
        {
            Console.WriteLine(productName);
        }

        Console.WriteLine("\nQuestion 3: Products priced between 10 and 30");

        var productsInPriceRange = ProductList.All
            .Where(product => product.UnitPrice >= 10m && product.UnitPrice <= 30m);

        foreach (var product in productsInPriceRange)
        {
            Console.WriteLine($"{product.ProductName} - {product.UnitPrice:C}");
        }
    }
}
