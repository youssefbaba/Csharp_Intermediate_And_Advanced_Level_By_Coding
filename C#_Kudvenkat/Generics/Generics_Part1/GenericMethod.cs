namespace Generics_Part1
{
    public class GenericMethod
    {
        public bool AreEqual<T>(T value1 , T value2)
        {
            //return value1 == value2; //  Error because compiler doesn't know the type of them and it assums them like objects type
            return value1.Equals(value2);
        }
    }
}
