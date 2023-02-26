using Microsoft.EntityFrameworkCore;
using RepairShop.Domain.Model.Entities;

namespace RepairShop.Tests
{
    [TestFixture]
    public class When_Quoting_a_muffler_in_warranty : Given_a_QuoteService
    {
        private Quote? Quote { get; set; }

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();

            RepairOrder = new RepairOrder
            {
                Vehicle = new Vehicle
                {
                    Customer = new Customer
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        PhoneNumber = "987654321"
                    },
                    Year = DateTime.Now.Year,
                    Make = "Ford",
                    Model = "Focus",
                    Odometer = 100000
                },
                Repairs = { Context.Repairs.Include(x => x.Parts).Single(x => x.Code == "MR001") }
            };

            Context.RepairOrders.Add(RepairOrder);
            Context.SaveChanges();

            Quote = SUT.GenerateQuote(RepairOrder.Id);
        }

        [Test]
        public void Then_a_Quote_is_returned()
        {
            Assert.IsInstanceOf<Quote>(Quote);
        }

        [Test]
        public void Then_the_Labor_total_is_correct()
        {
            Assert.AreEqual(0, Quote!.LaborTotal);
        }

        [Test]
        public void Then_the_Parts_total_is_correct()
        {
            Assert.AreEqual(0, Quote!.PartTotal);
        }

        [Test]
        public void Then_ToString_returns_the_finished_Quote()
        {
            var expected = $@"Repair Quote #{Quote!.Id}, Valid through {Quote.ExpiryDate:D}
Prepared for John Doe's {DateTime.Now.Year} Ford Focus.
---
Parts: 0.00
Labor: 0.00
---
Total: 0.00";
            var actual = Quote!.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
