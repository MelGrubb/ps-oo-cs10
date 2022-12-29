using System.Collections.Generic;
using System.Linq;

namespace Demo.Patterns.Strategy
{
    public class PointOfSale
    {
        public List<IDiscountStrategy> Discounts { get; } = new List<IDiscountStrategy>();

        public decimal GetBestDiscount(Order order)
        {
            return Discounts.Select(x => x.GetDiscount(order)).Max();
        }
    }
}
