using Demo.CarWorld;
using Demo.CarWorld.Electronics;
using NUnit.Framework;

namespace Tests.CarTests.HybridCarTests
{
    [TestFixture]
    public abstract class Given_a_hybrid_Car
    {
        protected Car SUT { get; set; }

        [SetUp]
        public virtual void SetUp()
        {
            SUT = new Car(new HybridControlModule());
        }
    }
}
