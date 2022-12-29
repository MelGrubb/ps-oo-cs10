namespace Demo.Patterns.Strategy
{
    public interface IDiscountStrategy
    {
        public decimal Percentage { get; set; }
        public decimal GetDiscount(Order order);
    }
}
