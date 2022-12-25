namespace Generics_Part1
{
    public class Nullable<T> where T : struct   // T is a value type
    {
        // Fields
        private object _value;


        // Constructors
        public Nullable()
        {
        }
        public Nullable(T value)
        {
            _value = value;  // Boxing 
        }


        // Methods
        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;  // Unboxing
            }
            return default(T);  
        }


        // Properties
        public bool HasValue
        {
            get
            {
                return _value != null;  
            }
        }
    }
}
