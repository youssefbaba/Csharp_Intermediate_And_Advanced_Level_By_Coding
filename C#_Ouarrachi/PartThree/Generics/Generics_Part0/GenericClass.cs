namespace Generics_Part0
{
    public class GenericClass<T>
    {
        // Generic Fields
        private T _genericField1;
        private T _genericField2;


        // Generic Constructors
        public GenericClass(T genericParam)
        {
            GenericField1 = genericParam;
            _genericField2 = default(T);
        }

        // Generic Methods
        public T Get()
        {
            return GenericField1;
        }


        // Generic properties
        public T GenericField1
        {
            get => _genericField1;
            set => _genericField1 = value;
        }

    }
}
