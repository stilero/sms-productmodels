namespace ProductModels;

public class PurchaseOrder
{
    public Guid Id { get; set; }
    public Location Location { get; set; }
    public Product Product { get; set; }
    public int OrderedQuantity { get; set; }
    public Unit Unit { get; set; }
}

public class GoodsReceipt
{
    public Guid Id { get; set; }
    public Location Location { get; set; }
    public Product Product { get; set; }
    public PurchaseOrder PurchaseOrder { get; set; }
    public int ReceivedQuantity { get; set; }
    public Unit ReceivedUnit { get; set; }
}
