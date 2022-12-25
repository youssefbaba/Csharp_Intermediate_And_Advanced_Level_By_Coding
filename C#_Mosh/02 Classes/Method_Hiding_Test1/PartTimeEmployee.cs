
namespace Method_Hiding_Test1
{
    public class PartTimeEmployee : Employee
    {
        // Fields
        public double HourlyIncome { get; set; }

        // Hiding Method => we use new keyword to hide base class members
        //public new void PrintFullName()
        //{
        //    //base.PrintFullName(); // Method one to invoke a hidden base class member from derived class
        //    Console.WriteLine($"{FirstName} {LastName} - Contractor");
        //}
    }
}
