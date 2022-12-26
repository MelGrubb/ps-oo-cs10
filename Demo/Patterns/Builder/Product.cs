namespace Demo.Patterns.Builder
{
    public class Product
    {
        public string Name { get; set; }
        public Component LeftComponent { get; set; }
        public Component RightComponent { get; set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}
