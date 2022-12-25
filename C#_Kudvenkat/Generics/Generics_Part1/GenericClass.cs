
namespace Generics_Part{
    public class GenericClass<T>
    {
        public bool AreEqual(T value1 , T value2)
        {
            return value1.Equals(value2);
        }
    }
}
