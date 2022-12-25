namespace Generics_Whats_And_Whys
{
    public class Nullable<T> where T : struct
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

        // Properties
        public bool HasValue
        {
            get
            {
                return _value != null;
            }
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


    }
}
