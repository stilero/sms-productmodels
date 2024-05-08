using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModels;

public static class WurthCases_Scenario5_6
{
   
    //Söppelsekker F-pak = 100, Min SalesOrder = 100, No conversion, Breakpack
    public static void Breakpack()
    {
        var fPak = new Unit { Id = Guid.NewGuid(), Name = "F-pak", ConversionFactor = 10, CanSplit = true, SplitToUnit = WurthSettings.baseUnit };
        var salesPak = new Unit { Id = Guid.NewGuid(), Name = "Sales-pak", ConversionFactor = 10, CanSplit = true, SplitToUnit = WurthSettings.baseUnit };

        var productSettings = new ProductHandling { 
            Id = Guid.NewGuid(), 
            Product = WurthSettings.Product1, 
            PurchaseUnit = WurthSettings.baseUnit, 
            SaleUnit = WurthSettings.baseUnit,
            MinQuantity = 0, 
            MaxQuantity = 1 
        };

        var innTelles = new Stock { 
            Id = Guid.NewGuid(), 
            Product = WurthSettings.Product1, 
            Quantity = 10, 
            Unit = fPak 
        };

        var stock = innTelles.GetStockInBaseUnit();
        var orderQuantity = productSettings.MaxQuantity * productSettings.PurchaseUnit.ConversionFactor;
        Console.WriteLine($"{nameof(WurthCases_Scenario5_6)} Breakpack=YES: Intelles: {innTelles.Quantity}, {innTelles.Unit.Name} Stock: {stock}, Order Quantity: {orderQuantity}");
    }

    //Söppelsekker F-pak = 100, Min SalesOrder = 100, No conversion, No Breakpack
    public static void NoBreakPack()
    {
        var fPak = new Unit { Id = Guid.NewGuid(), Name = "F-pak", ConversionFactor = 100, CanSplit = true, SplitToUnit = WurthSettings.baseUnit };

        var productSettings = new ProductHandling
        {
            Id = Guid.NewGuid(),
            Product = WurthSettings.Product1,
            PurchaseUnit = WurthSettings.baseUnit,
            SaleUnit = WurthSettings.baseUnit,
            MinQuantity = 0,
            MaxQuantity = 1
        };

        var innTelles = new Stock
        {
            Id = Guid.NewGuid(),
            Product = WurthSettings.Product1,
            Quantity = 1,
            Unit = WurthSettings.baseUnit
        };

        var stock = innTelles.GetStockInBaseUnit();
        var orderQuantity = productSettings.MaxQuantity * productSettings.PurchaseUnit.ConversionFactor;
        Console.WriteLine($"{nameof(WurthCases_Scenario5_6)} Breakpack=NO: Intelles: {innTelles.Quantity}, {innTelles.Unit.Name}  Stock: {stock}, Order Quantity: {orderQuantity}");

    }

}
