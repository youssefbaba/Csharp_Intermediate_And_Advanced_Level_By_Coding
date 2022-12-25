namespace Generics
{
    public class Nullable<T> where T : struct
    {
        // Fields
        private object _value;


        // Constructors
        public Nullable()
        {
        }
        public Nullable(T value)  // Boxing
        {
            _value = value;
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


        // Propeeties
        public bool HasValue
        {
            get
            {
                return _value != null;
            }
        }
    }
}