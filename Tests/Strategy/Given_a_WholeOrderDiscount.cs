using Demo.Patterns.Strategy;
using NUnit.Framework;

namespace Tests.Strategy
{
    [TestFixture]
    public class Given_a_WholeOrderDiscount
    {
        [Test]
        public void Then_the_discount_is_based_on_the_order_total()
        {
            var order = new Order
            {
                Items =
                {
                    new OrderItem { Quantity = 2, Price = 10.0m },
                    new OrderItem { Quantity = 1, Price = 5.0m },
                    new OrderItem { Quantity = 3, Price = 2.50m },
                }
            };

            var sut = new WholeOrderDiscount { Percentage = 0.15m };
            Assert.AreEqual(4.875m, sut.GetDiscount(order));
        }
    }
}
