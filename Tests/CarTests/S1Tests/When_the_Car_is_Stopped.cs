using NUnit.Framework;

namespace Tests.CarTests.S1Tests
{
    [TestFixture]
    public class When_the_Car_is_Stopped : Given_an_S1
    {
        [SetUp]
        override public void SetUp()
        {
            base.SetUp();
            SUT.Stop();
        }

        [Test]
        public void Then_IsRunning_is_false()
        {
            Assert.IsFalse(SUT.IsRunning);
        }
    }
}
