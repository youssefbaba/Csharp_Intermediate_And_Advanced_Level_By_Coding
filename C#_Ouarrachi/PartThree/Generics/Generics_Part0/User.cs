namespace Generics_Part0
{
    public class User : IComparable<User>
    {
        // Methods
        public int CompareTo(User? other)
        {
            return Name.CompareTo(other.Name);
        }


        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

    }
}