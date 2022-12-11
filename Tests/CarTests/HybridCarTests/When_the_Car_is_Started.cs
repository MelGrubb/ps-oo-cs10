using NUnit.Framework;

<<<<<<<< HEAD:Tests/CarTests/When_the_Car_is_Started.cs
namespace Tests.CarTests
{
    [TestFixture]
    public class When_the_Car_is_Started : Given_a_Car
========
namespace Tests.CarTests.HybridCarTests
{
    [TestFixture]
    public class When_the_Car_is_Started : Given_a_hybrid_Car
>>>>>>>> 04-solid-lsp:Tests/CarTests/HybridCarTests/When_the_Car_is_Started.cs
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
