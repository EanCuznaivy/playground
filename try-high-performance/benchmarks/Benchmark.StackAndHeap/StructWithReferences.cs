namespace Benchmark.StackAndHeap;

public struct StructWithReferences
{
    public StructWithReferences(
        int id,
        string name,
        decimal price,
        DateTime purchaseDate,
        Dictionary<string, string> keyValueData
    )
    {
        Id = id;
        Name = name;
        Price = price;
        PurchaseDate = purchaseDate;
        KeyValueData = keyValueData;
    }

    public int Id { get; }
    public string Name { get; }
    public decimal Price { get; }
    public DateTime PurchaseDate { get; }
    public Dictionary<string, string> KeyValueData { get; }
}