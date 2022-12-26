using Demo.Patterns.Builder;
using NUnit.Framework;

namespace Tests.BuilderTests.ProductBuilderTests
{
    [TestFixture]
    public class Given_a_ProductBuilder_for_Product_B
    {
        private ProductBuilder _sut = ProductBuilder.ForProductB();

        [Test]
        public void Then_Build_returns_Product_B()
        {
            var product = _sut.Build()!;
            Assert.AreEqual("Product B", product.Name);
            Assert.IsInstanceOf<Component2>(product.LeftComponent);
            Assert.IsInstanceOf<Component3>(product.RightComponent);
        }
    }
}
