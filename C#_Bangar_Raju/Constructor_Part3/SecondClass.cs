
namespace Constructor_Part3
{
    internal class SecondClass
    {
        // Fields
        public int Amount;

        // Constructors
        public SecondClass(int amount)
        {
            Amount = amount;
        }

        // Methods
        public override string ToString()
        {
            return $"{Amount}";
        }
    }
}
