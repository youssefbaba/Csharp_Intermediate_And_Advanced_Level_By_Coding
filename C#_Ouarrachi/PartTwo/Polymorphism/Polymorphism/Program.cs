namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Designer());  // Employee obj = new Designer();
            employees.Add(new Developer()); // Employee obj = new Developer();
            employees.Add(new Manager());   // Employee obj = new Manager();
            employees.Add(new Designer());  // Employee obj = new Designer();
            employees.Add(new Developer()); // Employee obj = new Developer();
            employees.Add(new Manager());   // Employee obj = new Manager();

            foreach (var employee in employees)
            {
                // when polymorphism is used correctly , it avoids codes that include many branches and tests
                string typeValue = employee.GetType().Name; // type at run time
                switch (typeValue)
                {
                    case "Designer":
                        new Designer().Show();
                        break;
                    case "Developer":
                        new Developer().Show();
                        break;
                    case "Manager":
                        new Manager().Show();
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine();

            foreach (var employee in employees)
            {
                Console.WriteLine($"At Compile Time : {GetTypeAtCompileTime(employee)}");
                Console.WriteLine($"At Run Time : {employee.GetType().Name}");
                employee.Show();    // Polymorphism
            }

            Console.WriteLine();

            Employee obj = new Manager();
            Console.WriteLine(obj);

        }
        public static string GetTypeAtCompileTime<T>(T value)
        {
            return typeof(T).Name;
        }
    }
}