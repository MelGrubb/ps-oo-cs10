using Demo;
using NUnit.Framework;

namespace Tests.CarTests
{
    [TestFixture]
    public abstract class Given_a_Car
    {
        protected Car SUT { get; set; }

        [SetUp]
        public virtual void SetUp()
        {
            SUT = new Car();
        }
    }
}
