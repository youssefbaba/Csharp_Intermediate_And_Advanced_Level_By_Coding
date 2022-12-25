namespace Generics
{
    public class GenericList<T>
    {
        // Methods
        public void Add(T value)
        {
            // Some Statements here ...
        }
        public T this[int index]
        {
            get
            {
                // Some statements here ...
                return default(T);
            }
        }
    }
}
