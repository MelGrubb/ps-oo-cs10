using Demo;
using NUnit.Framework;

namespace Tests.CarTests.S1Tests
{
    [TestFixture]
    public abstract class Given_an_S1
    {
        protected Car SUT { get; set; }

        [SetUp]
        public virtual void SetUp()
        {
            SUT = new S1();
        }
    }
}
