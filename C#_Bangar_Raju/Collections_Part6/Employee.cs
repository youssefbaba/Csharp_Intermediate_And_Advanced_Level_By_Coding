namespace Collections_Part6
{
    public class Employee : IComparable<Employee>   
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            if (Id > other.Id)
            {
                return 1;
            }
            else if (Id < other.Id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
