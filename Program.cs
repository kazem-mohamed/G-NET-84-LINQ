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
    }
}
