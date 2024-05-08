namespace ProductModels;

public static class WurthSettings
{
    public static Unit baseUnit { get; set; } = new () { Id = Guid.NewGuid(), Name = "Styck", ConversionFactor = 1, CanSplit = false };
    public static Unit defailtFPak { get; set; } = new () { Id = Guid.NewGuid(), Name = "F-Pak", ConversionFactor = 10, CanSplit = true, SplitToUnit = WurthSettings.baseUnit };

    public static Product Product1 { get; set; } = new() { Id = Guid.NewGuid(), Name = "Product 1", BaseUnit = WurthSettings.baseUnit };
}
