using Demo.CarWorld;
using Demo.CarWorld.Accessories;
using Demo.CarWorld.Electronics;
using NUnit.Framework;

namespace Tests.RemoteStarterTests
{
    [TestFixture]
    public class RemoteStarterTests
    {
        [Test]
        public void TestCarStarter()
        {
            var sut = new Car(new ElectricControlModule());
            var starter = new RemoteStarter(sut);
            starter.Start();
            Assert.IsTrue(sut.IsRunning);
            starter.Stop();
            Assert.IsFalse(sut.IsRunning);
        }

        [Test]
        public void TestGeneratorStarter()
        {
            var sut = new Generator();
            var starter = new RemoteStarter(sut);
            starter.Start();
            Assert.IsTrue(sut.IsRunning);
            starter.Stop();
            Assert.IsFalse(sut.IsRunning);
        }
    }
}
