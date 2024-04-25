namespace DemoShop.Models
{
    public class Rating
    {
        public double Rate { get; set; }
        public int IntegerRate
            => (int)Math.Round(Rate, MidpointRounding.AwayFromZero);
        public long Count { get; set; }
    }
}
