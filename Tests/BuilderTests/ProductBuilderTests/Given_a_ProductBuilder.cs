using Demo.Patterns.Builder;
using NUnit.Framework;
using System;

namespace Tests.BuilderTests.ProductBuilderTests
{
    [TestFixture]
    public class Given_a_ProductBuilder
    {
        private ProductBuilder _sut = new ProductBuilder();

        [Test]
        public void Then_Build_returns_null()
        {
            Assert.IsNull(_sut.Build());
        }

        [Test]
        public void Then_ForProduct_returns_the_expected_Product()
        {
            var productA = ProductBuilder.ForProduct("A")
                .WithLeftComponent(new Component3())
                .WithRightComponent(new Component1())
                .Build()!;
            Assert.AreEqual("Product A", productA.Name);
            Assert.IsInstanceOf<Component3>(productA.LeftComponent);
            Assert.IsInstanceOf<Component1>(productA.RightComponent);

            var productB = ProductBuilder.ForProduct("B").Build()!;
            Assert.AreEqual("Product B", productB.Name);
            Assert.IsInstanceOf<Component2>(productB.LeftComponent);
            Assert.IsInstanceOf<Component3>(productB.RightComponent);

            Assert.Throws<ArgumentException>(() => ProductBuilder.ForProduct("C").Build());
        }
    }
}
