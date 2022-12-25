namespace Generics_Part1
{
    public class Utilities  // Non-Generic class
    {
        // Methods
        public T Max<T>(T number1 , T number2) where T : IComparable    // Generic method inside Non-Generic class
        {
            return (number1.CompareTo(number2) > 0) ? number1 : number2;    
        }
    }
}