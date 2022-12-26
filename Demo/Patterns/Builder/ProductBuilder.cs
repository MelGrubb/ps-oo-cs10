using System;

namespace Demo.Patterns.Builder
{
    public class ProductBuilder : Builder<Product>
    {
        public static ProductBuilder ForProduct(string productType)
        {
            switch (productType)
            {
                case "A":
                    return ForProductA();
                case "B":
                    return ForProductB();
                default:
                    throw new ArgumentException($"Invalid product type '{productType}'.", nameof(productType));
            }
        }

        public static ProductBuilder ForProductA()
        {
            return new ProductBuilder() 
            { 
                Value = new Product("Product A")
                {
                    LeftComponent = new Component1(),
                    RightComponent = new Component2()
                }
            };
        }

        public static ProductBuilder ForProductB()
        {
            return new ProductBuilder() 
            { 
                Value = new Product("Product B")
                {
                    LeftComponent = new Component2(),
                    RightComponent = new Component3()
                }
            };
        }

        public ProductBuilder WithLeftComponent(Component component)
        {
            Value!.LeftComponent = component;
            return this;
        }

        public ProductBuilder WithRightComponent(Component component)
        {
            Value!.RightComponent = component;
            return this;
        }
    }
}
