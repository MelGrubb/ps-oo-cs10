using NUnit.Framework;

namespace Tests.CarTests.GeneratorTests
{
    [TestFixture]
    public class When_the_Generator_is_Stopped : Given_a_Generator
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
