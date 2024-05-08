namespace ProductModels;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    //public Company Company { get; set; }
    public Unit BaseUnit { get; set; } // Default to Eaches/Pieces
}

public class Unit
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    //public Company Company { get; set; }
    public int ConversionFactor { get; set; }
    public bool CanSplit { get; set; }
    public Unit SplitToUnit { get; set; }
}

public class ProductHandling
{
    public Guid Id { get; set; }
    public Product Product { get; set; }
    //public Location? Location { get; set; }
    public Unit PurchaseUnit { get; set; }
    public Unit SaleUnit { get; set; }
    public int MinQuantity { get; set; }
    public int MaxQuantity { get; set; }
}

public class Stock
{
    public Guid Id { get; set; }
    public Product Product { get; set; }
    //public StorageUnit StorageUnit { get; set; }
    public int Quantity { get; set; }
    public Unit Unit { get; set; } // Default to BaseUnit
    public int GetStockInBaseUnit() => Unit.CanSplit ? Quantity * Unit.ConversionFactor : Quantity;
}
