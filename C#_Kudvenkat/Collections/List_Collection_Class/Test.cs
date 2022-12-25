namespace List_Collection_Class
{
    public class Test
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee { Id = 101, Name = "John Doe", Salary = 120000 };
            Employee employee2 = new Employee { Id = 105, Name = "Mike Gavi", Salary = 114000 };
            Employee employee3 = new Employee { Id = 110, Name = "Gerard Alba", Salary = 130000 };
            Employee employee4 = new Employee { Id = 119, Name = "Jim Alonso", Salary = 110000 };
            Employee employee5 = new Employee { Id = 100, Name = "David Pedri", Salary = 142000 };

            List<Employee> listEmployees = new List<Employee>(2);  // Capacity 2 , 4 , 8 , 16 , 32 ..... 
            listEmployees.Add(employee1);
            listEmployees.Add(employee2);
            listEmployees.Add(employee3);
            listEmployees.Add(employee4);
            listEmployees.Add(employee5);



            Console.WriteLine($"Capacity of our list is : {listEmployees.Capacity}");
            Console.WriteLine();


            Console.WriteLine("------ First Employee ------");
            Console.WriteLine($"Id = {listEmployees[0].Id} , Name = {listEmployees[0].Name} , Salary = {listEmployees[0].Salary}");
            Console.WriteLine();


            Console.WriteLine("------ Display Elements of listEmployees by using foreach loop ------");
            foreach (Employee employe in listEmployees)
            {
                Console.WriteLine($"Id = {employe.Id} , Name = {employe.Name} , Salary = {employe.Salary}");
            }
            Console.WriteLine();


            Console.WriteLine("------ Display Elements of listEmployees by using for loop ------");
            for (int i = 0; i < listEmployees.Count; i++)
            {
                Console.WriteLine($"Id = {listEmployees[i].Id} , Name = {listEmployees[i].Name} , Salary = {listEmployees[i].Salary}");
            }
            Console.WriteLine();


            ChildEmployee childEmployee = new ChildEmployee { Id = 101, Name = "Youssef Baba", Salary = 200000 };
            listEmployees.Add(childEmployee);  // Implicit conversion to Employee


            Employee employee6 = new Employee { Id = 106, Name = "Mohamed Zidani", Salary = 190000 };
            listEmployees.Insert(0, employee5); // insert old employee in index 0
            listEmployees.Insert(1, employee6); // Insert new employee in index 1
            foreach (Employee employe in listEmployees)
            {
                Console.WriteLine($"Id = {employe.Id} , Name = {employe.Name} , Salary = {employe.Salary}");
            }
            Console.WriteLine();


            Console.WriteLine($"Index of the first occurence of employee5 is : {listEmployees.IndexOf(employee5)}");
            Console.WriteLine($"Index of the second occurence of employee5 is : {listEmployees.IndexOf(employee5, listEmployees.IndexOf(employee5) + 1)}");
            Console.WriteLine($"Index of the first occurence of employee5 in range of 3 elements is : {listEmployees.IndexOf(employee5, 1 ,3)}");
            Console.WriteLine();


            listEmployees.RemoveAt(2);
            foreach (Employee employe in listEmployees)
            {
                Console.WriteLine($"Id = {employe.Id} , Name = {employe.Name} , Salary = {employe.Salary}");
            }
            Console.WriteLine();











        }
    }
}