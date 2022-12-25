namespace Keyword_Is_And_As
{
    public class ContractEmployee : Employee
    {
        // Constructors
        public ContractEmployee(int id, string name , int hourlySalary) : base(id, name)
        {
            HourlySalary = hourlySalary;
        }


        // Properties
        public int HourlySalary { get; set; }

    }
}