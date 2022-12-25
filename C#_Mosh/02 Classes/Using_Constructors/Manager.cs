
namespace Using_Constructors
{
    public class Manager : Employee
    {
        // Fields
        public int Id { get; set; }

        // Constructors
        //public Manager() // Implicit call to base class parameterless constructor
        //{
        //}
        public Manager() : base() // Implicit call to base class parameterless constructor
        {
        }
        public Manager(int id, int annualSalary) : base(annualSalary)
        {
            Id = id;
        }



    }
}
