using Demo;
using NUnit.Framework;

namespace Tests.CarTests.EC1Tests
{
    [TestFixture]
    public abstract class Given_an_EC1
    {
        protected Car SUT { get; set; }

        [SetUp]
        public virtual void SetUp()
        {
            SUT = new EC1();
        }
    }
}
