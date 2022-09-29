namespace Benchmark.StackAndHeap;

public struct StructNoReferences
{
    public StructNoReferences(
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