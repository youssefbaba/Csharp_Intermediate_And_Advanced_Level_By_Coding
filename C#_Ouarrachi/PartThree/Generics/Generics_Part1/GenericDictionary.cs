namespace Generics_Part1
{
    public class GenericDictionary<TKey , TValue>
    {
        // Methods 
        public void Add(TKey key , TValue value)
        {
            // Some logic here ....
        }
        public TValue this[TKey key]
        {
            get { return default; }
            
        }
    }
}