namespace Properties_Part0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(20);
            // Console.WriteLine($"Age = {person._age}");  // Compile time error : it is not accessible because it is private by default
            // person._age = 30; // Compile time error : it is not accessible because it is private by default


            /*
            Console.WriteLine($"Current age = {person.GetAge()}");
            person.SetAge(30);
            Console.WriteLine($"Modified age = {person.GetAge()}");
            */


            Console.WriteLine($"Current age = {person.Age}");
            person.Age = 30;
            Console.WriteLine($"Modified age = {person.Age}");


            Employee employee = new Employee("John" , 120000.00);
            // employee.Name += "Doe"; // Complie time error : cannot be assigned to because it is read-only property
            Console.WriteLine($"Name = {employee.Name}");
            employee.Salary = 200000.00;
            //Console.WriteLine($"Salary = {employee.Salary}");  // Complite time error : cannot get the value of property Salary because it is Write-only property


            Car car = new Car("ABDC1234", "Red", 150000.00);
            Console.WriteLine($"Number Of Seat = {Car.NumberSeat}");
            Car.NumberSeat = 2;
            Console.WriteLine($"Number Of Seat = {Car.NumberSeat}");


        }
    }
}