using Demo.Patterns.Strategy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Strategy
{
    [TestFixture]
    public class Given_a_HighestPriceItemDiscount
    {
        [Test]
        public void Then_the_discount_is_based_on_the_highest_priced_item()
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

            var sut = new HighestPriceItemDiscount { Percentage = 0.5m };
            Assert.AreEqual(5.0m, sut.GetDiscount(order));
        }
    }
}
