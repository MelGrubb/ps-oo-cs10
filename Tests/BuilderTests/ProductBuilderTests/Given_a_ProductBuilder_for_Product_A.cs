using Demo.Patterns.Builder;
using NUnit.Framework;

namespace Tests.BuilderTests.ProductBuilderTests
{
    [TestFixture]
    public class Given_a_ProductBuilder_for_Product_A
    {
        private ProductBuilder _sut = ProductBuilder.ForProductA();

        [Test]
        public void Then_Build_returns_Product_A()
        {
            var product = _sut.Build()!;
            Assert.AreEqual("Product A", product.Name);
            Assert.IsInstanceOf<Component1>(product.LeftComponent);
            Assert.IsInstanceOf<Component2>(product.RightComponent);
        }
    }
}
