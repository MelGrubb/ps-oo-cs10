using RepairShop.Domain.Model.Entities;

namespace RepairShop.Tests
{
    [TestFixture]
    public class When_Quoting_an_oil_change : Given_a_QuoteService
    {
        private Quote? Quote { get; set; }

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();

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
            Assert.AreEqual(50, Quote!.LaborTotal);
        }

        [Test]
        public void Then_the_Parts_total_is_correct()
        {
            Assert.AreEqual(78.98M, Quote!.PartTotal);
        }

        [Test]
        public void Then_ToString_returns_the_finished_Quote()
        {
            var expected = $@"Repair Quote #{Quote!.Id}, Valid through {Quote.ExpiryDate:D}
Prepared for John Doe's 0  .
---
Parts: 78.98
Labor: 50.0
---
Total: 128.98";
            var actual = Quote!.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
