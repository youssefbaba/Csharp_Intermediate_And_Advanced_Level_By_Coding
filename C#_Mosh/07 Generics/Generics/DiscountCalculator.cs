namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product   // where TProduct is of type Product
    {
        // Methods
        public float CalculateDiscount(TProduct product)
        {
            return product.Price * 0.2f;
        }
    }

}