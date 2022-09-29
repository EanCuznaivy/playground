namespace Benchmark.StackAndHeap;

public class ClassNoReferences
{
    public ClassNoReferences(
        int id,
        decimal price,
        DateTime purchaseDate
    )
    {
        Id = id;
        Price = price;
        PurchaseDate = purchaseDate;
    }

    public int Id { get; }
    public decimal Price { get; }
    public DateTime PurchaseDate { get; }
}