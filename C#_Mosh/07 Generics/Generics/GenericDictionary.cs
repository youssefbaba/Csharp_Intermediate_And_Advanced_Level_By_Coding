namespace Generics
{
    public class GenericDictionary<TKey, TValue>
    {
        // Methods
        public void Add(TKey key, TValue value)
        {
            // Some Statements here ...
        }
        public TValue this[TKey key]
        {
            get
            {
                // Some statements here ...
                return default(TValue);
            }
        }
    }

}