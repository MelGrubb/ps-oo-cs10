using NUnit.Framework;

<<<<<<<< HEAD:Tests/CarTests/When_the_Car_is_Stopped.cs
namespace Tests.CarTests
{
    [TestFixture]
    public class When_the_Car_is_Stopped : Given_a_Car
========
namespace Tests.CarTests.GasolineCarTests
{
    [TestFixture]
    public class When_the_Car_is_Stopped : Given_a_gasoline_Car
>>>>>>>> 04-solid-lsp:Tests/CarTests/GasolineCarTests/When_the_Car_is_Stopped.cs
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
