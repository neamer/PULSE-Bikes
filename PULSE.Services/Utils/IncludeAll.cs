using PULSE.Model.SearchObjects;

namespace PULSE.Services.Utils;

public static class IncludeAll
{
    public static readonly BicycleSearchObject Bicycle = new BicycleSearchObject()
    {
        IncludeBrand = true,
        IncludeCategory = true,
        IncludeSizes = true
    };
    
    public static readonly GearSearchObject Gear = new GearSearchObject()
    {
        IncludeBrand = true,
        IncludeCategory = true,
    };
    
    public static readonly PartSearchObject Part = new PartSearchObject()
    {
        IncludeBrand = true,
        IncludeCategory = true,
    };
}