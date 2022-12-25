using System.Security.Cryptography.X509Certificates;

namespace Delegates_Usage
{
    // Defining Delegate :
    public delegate bool DelegatePromotableEmployee(Employee employee);
    public class Test
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 101, Name = "John", Salary = 60000, Experience = 6 });
            employees.Add(new Employee { Id = 102, Name = "Mike", Salary = 40000, Experience = 4 });
            employees.Add(new Employee { Id = 103, Name = "David", Salary = 30000, Experience = 3 });
            employees.Add(new Employee { Id = 104, Name = "Gerard", Salary = 50000, Experience = 5 });

            /*
             
            // Instantiating the delegate by using Anonymous Method : 
            DelegatePromotableEmployee delegatePromotableEmployee = delegate(Employee emp)
            {
                return (emp.Experience >= 5 && emp.Salary <= 50000);
            };
            Employee.PromoteEmploye(employees, delegatePromotableEmployee);

            */

            
            // Instantiating the delegate by using Lambda Expression :
            DelegatePromotableEmployee delegatePromotableEmployee = (emp) => (emp.Experience >= 5 && emp.Salary <= 50000);
            Employee.PromoteEmploye(employees, delegatePromotableEmployee);
            
        }
    }

}