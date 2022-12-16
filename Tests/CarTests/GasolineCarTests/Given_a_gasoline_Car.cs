using Demo.CarWorld;
using Demo.CarWorld.Electronics;
using NUnit.Framework;

namespace Tests.CarTests.GasolineCarTests
{
    [TestFixture]
    public abstract class Given_a_gasoline_Car
    {
        protected Car SUT { get; set; }

        [SetUp]
        public virtual void SetUp()
        {
            SUT = new Car(new IceControlModule());
        }
    }
}
