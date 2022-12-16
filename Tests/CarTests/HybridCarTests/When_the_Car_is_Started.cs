using Demo.CarWorld;
using NUnit.Framework;

namespace Tests.CarTests.HybridCarTests
{
    [TestFixture]
    public class When_the_Car_is_Started : Given_a_hybrid_Car
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            var startable = (IStartable)SUT;
            startable.Start();
        }

        [Test]
        public void Then_IsRunning_is_true()
        {
            Assert.IsTrue(SUT.IsRunning);
        }
    }
}
