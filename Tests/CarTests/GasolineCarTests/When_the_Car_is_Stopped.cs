using Demo.CarWorld;
using NUnit.Framework;

namespace Tests.CarTests.GasolineCarTests
{
    [TestFixture]
    public class When_the_Car_is_Stopped : Given_a_gasoline_Car
    {
        [SetUp]
        override public void SetUp()
        {
            base.SetUp();
            var startable = (IStartable)SUT;
            startable.Stop();
        }

        [Test]
        public void Then_IsRunning_is_false()
        {
            Assert.IsFalse(SUT.IsRunning);
        }
    }
}
