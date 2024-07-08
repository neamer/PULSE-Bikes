namespace PULSE.Model
{
  public enum BicyclePriceStatsRange
  {
    TO_500,
    FROM_500_TO_1000,
    FROM_1000_TO_1500,
    FROM_1500_TO_2500,
    FROM_2500_TO_5000,
    FROM_5000
  }

  public partial class BicyclePriceStats
  {
    public BicyclePriceStatsRange? Range { get; set; }
    public decimal? Value { get; set; }
  }
}
