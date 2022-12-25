namespace Generics_Part2
{
    public class Employee  : IComparable<Employee>
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(Employee? other)
        {
            return Id.CompareTo(other.Id);
        }

        //public int CompareTo(Employee? other)
        //{
        //    return Name.CompareTo(other.Name);
        //}

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
