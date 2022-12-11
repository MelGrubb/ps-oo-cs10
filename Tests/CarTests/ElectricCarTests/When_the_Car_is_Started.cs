using NUnit.Framework;

namespace Tests.CarTests.ElectricCarTests
{
    [TestFixture]
    public class When_the_Car_is_Started : Given_an_electric_Car
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            SUT.Start();
        }

        [Test]
        public void Then_IsRunning_is_true()
        {
            Assert.IsTrue(SUT.IsRunning);
        }
    }
}
