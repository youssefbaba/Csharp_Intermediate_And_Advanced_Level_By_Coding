namespace Generics_Part1
{
    public class DiscountCalculator<TProduct> where TProduct : Product   // TProduct
    {
        // Methods
        public double CalculateDiscount(TProduct product)
        {
            return product.Price * 0.1;
        }
    }
}