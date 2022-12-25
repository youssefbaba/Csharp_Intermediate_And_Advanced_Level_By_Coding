using System.Collections.ObjectModel;

namespace Some_Useful_Methods_Of_List_Collection_Class
{
    public class Test
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { Id = 110, Name = "David Alaba", Salary = 120000.00};
            Employee employee2 = new Employee { Id = 107, Name = "Gerard Alonso", Salary = 90000.00};
            Employee employee3 = new Employee { Id = 104, Name = "Jim Pedri", Salary = 100000.00};
            Employee employee4 = new Employee { Id = 101, Name = "Marks Gea", Salary = 110000.00};
            Employee employee5 = new Employee { Id = 115, Name = "John Doe", Salary = 115000.00};

            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(employee1);
            listEmployees.Add(employee2);
            listEmployees.Add(employee3);
            listEmployees.Add(employee4);
            listEmployees.Add(employee5);

            Console.WriteLine("------ list of employees ------");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"Id = {employee.Id} , Name = {employee.Name} , Salary = {employee.Salary}");
            }
            Console.WriteLine();


            Console.WriteLine("------ TrueForAll Method ------");
            //Predicate<Employee> obj = employee => employee.Salary >= 100000.00; 
            //Predicate<Employee> obj1 = employee => employee.Salary >= 90000.00;

            //if (listEmployees.TrueForAll(employee => employee.Salary >= 100000.00)) // False
            if (listEmployees.TrueForAll(employee => employee.Salary >= 90000.00)) // True
            {
                Console.WriteLine("All salaries matches the conditions defined by the specified predicate");
            }
            else
            {
                Console.WriteLine("Not all salaries matches the conditions defined by the specified predicate");
            }
            Console.WriteLine();


            Console.WriteLine("------ AsReadOnly Method ------");
            ReadOnlyCollection<Employee> readOnlyEmployees  =  listEmployees.AsReadOnly(); // we can't remove or add  or insert elements to that ReadOnlyColletion we can only read elements from it 
            // readOnlyEmployees.Add()  : I don't have any overload of add method
            // readOnlyEmployees.Remove()  : I don't have any overload of remove method
            // readOnlyEmployees.Insert()  : I don't have any overload of insert method
            for (int i = 0; i < readOnlyEmployees.Count; i++)
            {
                Console.WriteLine($"Id = {readOnlyEmployees[i].Id} , Name = {readOnlyEmployees[i].Name} , Salary = {readOnlyEmployees[i].Salary}");
            }
            Console.WriteLine();


            Console.WriteLine("------ TrimExcess Method ------");
            List<int> numbers = new List<int>(100);
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);
            numbers.Add(60);
            numbers.Add(70);
            Console.WriteLine("------ Capacity and Count before Triming ------");
            Console.WriteLine($"Capacity : {numbers.Capacity}"); // 100
            Console.WriteLine($"Count : {numbers.Count}"); // 7
            Console.WriteLine();


            Console.WriteLine("------ Capacity and Count after Triming ------");
            numbers.TrimExcess();
            Console.WriteLine($"Capacity : {numbers.Capacity}"); // 7
            Console.WriteLine($"Count : {numbers.Count}"); // 7
            Console.WriteLine();


            Console.WriteLine("------ Capacity and Count after Clearing ------");
            numbers.Clear();
            Console.WriteLine($"Capacity : {numbers.Capacity}"); // 7
            Console.WriteLine($"Count : {numbers.Count}"); // 0
            Console.WriteLine();


            Console.WriteLine("------ Capacity and Count after adding elements ------");
            for (int i = 0; i < 15; i++)
            {
                numbers.Add(i);
            }
            Console.WriteLine($"Capacity : {numbers.Capacity}"); // 28
            Console.WriteLine($"Count : {numbers.Count}"); // 15



        }
    }
}