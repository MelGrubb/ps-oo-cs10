namespace Demo.Patterns.Builder
{
    public class Product
    {
        public string Name { get; set; }
        public Component? LeftComponent { get; set; } = null;
        public Component? RightComponent { get; set; } = null;

        public Product(string name)
        {
            Name = name;
        }
    }
}
