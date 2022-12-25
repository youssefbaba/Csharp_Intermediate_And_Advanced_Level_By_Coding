namespace Collection_Part7
{
    public class CompareProduct : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
