namespace Keyword_Is_And_As
{
    public class PermanentEmployee : Employee
    {
        // Constructors
        public PermanentEmployee(int id, string name, int annualSalary) : base(id, name)
        {
            AnnualSalary = annualSalary;
        }


        // Properties
        public int AnnualSalary { get; set; }
    }
}