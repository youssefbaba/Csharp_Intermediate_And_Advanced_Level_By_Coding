
namespace Objects_Create_Instances_Of_Type
{
    public struct Employee
    {
        // Fields
        public int Id { get; set; }
        public string Name { get; set; }

        // Constructor
        public Employee(int id , string name)
        {
            Id = id;
            Name = name;
        }
    }
}
