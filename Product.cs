namespace G_NET_84_LINQ;

public sealed record Product(
    int ProductId,
    string ProductName,
    string Category,
    decimal UnitPrice,
    int UnitsInStock);
