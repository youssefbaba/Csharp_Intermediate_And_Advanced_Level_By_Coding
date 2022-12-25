using System.Collections;

namespace Collections_Part8
{
    public class Test
    {
        static void Main(string[] args)
        {
            /*
            
            - IEnumerable
                - ICollection
                    - IList : Classes ArrayList , List<T> , ... that store the values by using index Implement IList interface
                    - IDictionary : Classes HashTable , Dictionary<T,T> , ... that store the values by using key/value Implement IDictionary interface
             
             
             */

            Organization employees = new Organization();
            //List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 101, Name = "Gerard Alba", Job = "Manager", Salary = 111000.00 });
            employees.Add(new Employee { Id = 101, Name = "David Xavi", Job = "Analyst", Salary = 110000.00 });
            employees.Add(new Employee { Id = 103, Name = "Daniel Alves", Job = "SalesMan", Salary = 112000.00 });
            employees.Add(new Employee { Id = 104, Name = "Mark Huge", Job = "Director", Salary = 115000.00 });
            employees.Add(new Employee { Id = 105, Name = "John Doe", Job = "Developer", Salary = 120000.00 });
            employees.Add(new Employee { Id = 106, Name = "Alvaro Toti", Job = "Designer", Salary = 119000.00 });

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Id} , {employee.Name} , {employee.Job} , {employee.Salary}");
            }
            Console.WriteLine();

        }
    }
}