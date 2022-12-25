
namespace Using_Constructors
{
    public class PreventInstantiation
    {
        // Fields
        public static double Amount = Math.E;
        public string Message { get; set; } // default value is null

        // Constructors
        private PreventInstantiation()
        {
        }
    }
}
