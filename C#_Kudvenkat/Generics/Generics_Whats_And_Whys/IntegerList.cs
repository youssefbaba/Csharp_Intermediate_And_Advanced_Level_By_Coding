namespace Generics_Whats_And_Whys
{
    // We want to store numbers in the list
    public class IntegerList
    {
        // Methods
        public void Add(int value) // to add a number in the list
        {
            throw new NotImplementedException();
        }
        public int this[int index] // to get a number by this index
        {
            get { throw new NotFiniteNumberException(); }
        }
    }
}
