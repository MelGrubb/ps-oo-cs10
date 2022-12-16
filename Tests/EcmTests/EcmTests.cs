using Demo;
using Demo.CarWorld;
using Demo.CarWorld.Electronics;
using NUnit.Framework;

namespace Tests.EcmTests
{
    [TestFixture]
    public class EcmTests
    {
        private void TestEcm(EngineControlModule sut)
        {
            sut.Start();
            Assert.IsTrue(sut.IsRunning);
            sut.Stop();
            Assert.IsFalse(sut.IsRunning);
        }

        [Test]
        public void TestIceControlModule()
        {
            TestEcm(new IceControlModule());
        }

        [Test]
        public void TestElectricControlModule()
        {
            TestEcm(new ElectricControlModule());
        }

        [Test]
        public void TestHybridControlModule()
        {
            TestEcm(new HybridControlModule());
        }
    }
}
