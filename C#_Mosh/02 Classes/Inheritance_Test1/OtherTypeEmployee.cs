
namespace Inheritance_Test1
{
    //public class OtherTypeEmployee : Employee , FullTimeEmployee  // Error because C# doesn't support multiple directly inheritance
    public  class OtherTypeEmployee : FullTimeEmployee 
    {
        // OtherTypeEmployee inherits from FullTimeEmployee and FullTimeEmployee inherits from Employee
    }
}
