namespace Generics_Whats_And_Whys
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {

        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}
