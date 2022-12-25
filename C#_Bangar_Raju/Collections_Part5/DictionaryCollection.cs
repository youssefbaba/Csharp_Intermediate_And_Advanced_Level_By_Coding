using System.Collections;

namespace Collections_Part5
{
    public class DictionaryCollection
    {
        static void Main(string[] args)
        {
            /*

            Dictionary<string, object> dictionary = new Dictionary<string, object>() // Creating Dictionary by using collection initializer syntax :
            {
                {"EmployeeId" , 1010},
                {"EmployeeName" , "john doe"},
                {"Job" , "manager"},
                {"Salary" , 25000.00},
                {"MangerId" , 1002},
                {"Phone" , "+221251485745"},
                {"Email" , "john@gmail.com"},
                {"DepartementName" , "sales"},
                {"Location" , "madrid"},
                {"DepartmentId" , 30},
            };

            */
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("EmployeeId", 1010);
            dictionary.Add("EmployeeName", "john doe");   
            dictionary.Add("Job", "manager");
            dictionary.Add("Salary", 25000.00);
            dictionary.Add("MangerId", 1002);
            dictionary.Add("Phone", "+221251485745");
            dictionary.Add("Email", "john@gmail.com");
            dictionary.Add("DepartementName", "sales");
            dictionary.Add("Location", "madrid");
            dictionary.Add("DepartmentId", 30);

            Console.WriteLine($"Email : {dictionary["Email"]}");
            Console.WriteLine();

            Console.WriteLine("-------- Key : Value --------");
            foreach (KeyValuePair<string , object> item in dictionary)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.WriteLine();

            Console.WriteLine("-------- Key --------");
            foreach (string key in dictionary.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            Console.WriteLine("-------- Value --------");
            foreach (object value in dictionary.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            Console.WriteLine("-------- Key : Value --------");
            foreach (string key in dictionary.Keys)
            {
                Console.WriteLine($"{key} : {dictionary[key]}");
            }
            Console.WriteLine();


            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee { Id = 1, Name = "John Doe", Email = "John@gmail.com", Salary = 120000.00 });
            employees.Add(new Employee { Id = 2, Name = "Mark Huge", Email = "Mark@gmail.com", Salary = 115000.00 });
            employees.Add(new Employee { Id = 3, Name = "David Xavi", Email = "David@gmail.com", Salary = 110000.00 });
            employees.Add(new Employee { Id = 4, Name = "Gerard Alba", Email = "Gerard@gmail.com", Salary = 111000.00 });

            /*
            Employee employee1 = new Employee { Id = 1, Name = "John Doe", Email = "John@gmail.com", Salary = 120000.00 };
            Employee employee2 = new Employee { Id = 2, Name = "Mark Huge", Email = "Mark@gmail.com", Salary = 115000.00 };
            Employee employee3 = new Employee { Id = 3, Name = "David Xavi", Email = "David@gmail.com", Salary = 110000.00 };
            Employee employee4 = new Employee { Id = 4, Name = "Gerard Alba", Email = "Gerard@gmail.com", Salary = 111000.00 };
            Employee[] arrayEmployees = new Employee[] { employee1, employee2, employee3, employee4 };
            employees.AddRange(arrayEmployees);
            */

            Console.Write("Employees : [ ");
            foreach (Employee employee in employees )
            {
                Console.Write("{" + employee.Id + " , " + employee.Name+ " , " + employee.Email + " , " + employee.Salary + "} ");
            }
            Console.Write("]");
            Console.WriteLine();

            employees.Insert(2, new Employee { Id = 5, Name = "Daniel Alves", Email = "Daniel@gmail.com", Salary = 112000.00 });
            employees.Insert(3, new Employee { Id = 6, Name = "Alvaro Toti", Email = "Alvaro@gmail.com", Salary = 119000.00 });
            Console.Write("Employees : [ ");
            foreach (Employee employee in employees)
            {
                Console.Write("{" + employee.Id + " , " + employee.Name + " , " + employee.Email + " , " + employee.Salary + "} ");
            }
            Console.Write("]");
            Console.WriteLine();

            employees.RemoveAt(2);
            Console.Write("Employees : [ ");
            foreach (Employee employee in employees)
            {
                Console.Write("{" + employee.Id + " , " + employee.Name + " , " + employee.Email + " , " + employee.Salary + "} ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
