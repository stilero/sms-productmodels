namespace ProductModels;

public static class WurthCases_Scenario1_2
{
   
    //Söppelsekker F-pak = 100, Min SalesOrder = 100, No conversion, Breakpack
    public static void Scenario1_Breakpack()
    {
        var fPak = new Unit { Id = Guid.NewGuid(), Name = "F-pak", ConversionFactor = 10, CanSplit = true, SplitToUnit = WurthSettings.baseUnit };
        
        var productSettings = new ProductHandling { 
            Id = Guid.NewGuid(), 
            Product = WurthSettings.Product1, 
            PurchaseUnit = WurthSettings.baseUnit, 
            SaleUnit = WurthSettings.baseUnit,
            MinQuantity = 0, 
            MaxQuantity = 100 
        };

        var innTelles = new Stock { 
            Id = Guid.NewGuid(), 
            Product = WurthSettings.Product1, 
            Quantity = 1, 
            Unit = fPak 
        };

        var stock = innTelles.GetStockInBaseUnit();
        var orderQuantity = productSettings.MaxQuantity * productSettings.PurchaseUnit.ConversionFactor;
        var salesQuantity = productSettings.SaleUnit.ConversionFactor;
        Console.WriteLine($"SCENARIO1 Breakpack=YES: Intelles: {innTelles.Quantity}, {innTelles.Unit.Name} Stock: {stock}, Order Quantity: {orderQuantity}, SaleQty: {salesQuantity}");
    }

    //Söppelsekker F-pak = 100, Min SalesOrder = 100, No conversion, No Breakpack
    public static void Scenario1_NoBreakPack()
    {
        var fPak = new Unit { Id = Guid.NewGuid(), Name = "F-pak", ConversionFactor = 10, CanSplit = true, SplitToUnit = WurthSettings.baseUnit };

        var productSettings = new ProductHandling
        {
            Id = Guid.NewGuid(),
            Product = WurthSettings.Product1,
            PurchaseUnit = WurthSettings.baseUnit,
            SaleUnit = WurthSettings.baseUnit,
            MinQuantity = 0,
            MaxQuantity = 100
        };

        var innTelles = new Stock
        {
            Id = Guid.NewGuid(),
            Product = WurthSettings.Product1,
            Quantity = 100,
            Unit = WurthSettings.baseUnit
        };

        var stock = innTelles.GetStockInBaseUnit();
        var orderQuantity = productSettings.MaxQuantity * productSettings.PurchaseUnit.ConversionFactor;
        var salesQuantity = productSettings.SaleUnit.ConversionFactor;
        Console.WriteLine($"SCENARIO1 Breakpack=NO: Intelles: {innTelles.Quantity}, {innTelles.Unit.Name}  Stock: {stock}, Order Quantity: {orderQuantity}, SaleQty: {salesQuantity}");

    }

}
