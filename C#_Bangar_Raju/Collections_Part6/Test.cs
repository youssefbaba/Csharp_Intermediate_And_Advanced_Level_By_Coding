namespace Collections_Part6
{
    public class Test
    {
        static void Main(string[] args)
        {
            Student student1 = new Student { StudentId = 103, Name = "David", Class = 10, Marks = 550.50f };
            Student student2 = new Student { StudentId = 106, Name = "Jean", Class = 10, Marks = 489.65f };
            Student student3 = new Student { StudentId = 104, Name = "Jim", Class = 10, Marks = 510.14f };
            Student student4 = new Student { StudentId = 102, Name = "Gerard", Class = 10, Marks = 470.30f };
            Student student5 = new Student { StudentId = 101, Name = "Xavi", Class = 10, Marks = 536.48f };
            Student student6 = new Student { StudentId = 105, Name = "Marks", Class = 10, Marks = 513.47f };
            List<Student> students = new List<Student> { student1, student2, student3, student4, student5, student6 };
            Console.WriteLine("------ Display Students ------");
            students.Sort();
            //students.Reverse();
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.StudentId} , {student.Name} , {student.Class} , {student.Marks}");
            }
            Console.WriteLine();


            List<float> listMarks = new List<float> { 550.50f, 489.65f, 510.14f, 470.30f, 536.48f, 513.47f };
            Console.WriteLine("------ Display Marks ------");
            listMarks.Sort();
            //listMarks.Reverse();
            foreach (float item in listMarks)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();


            List<string> listNames = new List<string> { "David", "Jean", "Jim", "Gerard", "Xavi", "Marks" };
            Console.WriteLine("------ Display Names ------");
            listNames.Sort();
            //listNames.Reverse();
            foreach (string item in listNames)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();


            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 4, Name = "Gerard Alba", Email = "Gerard@gmail.com", Salary = 111000.00 });
            employees.Add(new Employee { Id = 3, Name = "David Xavi", Email = "David@gmail.com", Salary = 110000.00 });
            employees.Add(new Employee { Id = 5, Name = "Daniel Alves", Email = "Daniel@gmail.com", Salary = 112000.00 });
            employees.Add(new Employee { Id = 2, Name = "Mark Huge", Email = "Mark@gmail.com", Salary = 115000.00 });
            employees.Add(new Employee { Id = 1, Name = "John Doe", Email = "John@gmail.com", Salary = 120000.00 });
            employees.Add(new Employee { Id = 6, Name = "Alvaro Toti", Email = "Alvaro@gmail.com", Salary = 119000.00 });
            employees.Sort(); // Based on Id
            employees.Reverse();
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Id} , {employee.Name} , {employee.Email} , {employee.Salary}");
            }
            Console.WriteLine();


            CompareEmployee compareEmployee = new CompareEmployee();
            //employees.Sort(); // Based on Id
            employees.Sort(compareEmployee);  // Based on Salary
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Id} , {employee.Name} , {employee.Email} , {employee.Salary}");
            }
            Console.WriteLine();



        }
    }
}