namespace Collection_Part7
{
    public class Product : IComparable<Product>
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public int CompareTo(Product other)
        {
            if (Price > other.Price)
            {
                return 1;

            }
            else if (Price < other.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
